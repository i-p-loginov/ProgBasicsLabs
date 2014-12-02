using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace CsvSerializationSample
{
    public class CsvSerializer<T> where T : new()
    {
        //символ-разделитель по-умолчанию
        public const char DefaultSeparatorCharacter = ';';

        //в этом поле хранятся информация о свойствах типа T
        private readonly static PropertyInfo[] _properties;

        //символ-разделитель, который может быть изменён пользователем, 
        //по-умолчанию - ';'
        private readonly char _separatorCharacter = DefaultSeparatorCharacter;

        //кодировка, в которой будет сохранено содержимое (или прочитано)
        private readonly Encoding _encoding = Encoding.Default;

        //массивы байт, представляющие символ-разделитель и символ конца строки
        private readonly byte[] _seperatorBytes;
        private readonly byte[] _newLineBytes;

        static CsvSerializer()
        {
            //получаем свойства, выбирая лишь те, для которых не объявлен атрибут CsvNonSerializable,
            //а также - имя свойства - не специальное (это значит, что у свойства какое-то своё служебное назначение)
            var props = typeof(T).GetProperties().Where(prop => !prop.IsSpecialName && !prop.IsDefined(typeof(CsvNonSerializableAttribute), true))
                                                 .ToArray();

            //выбираем все свойства с явно заданным порядком
            var explicitOrderedProps = props.Where(p => p.IsDefined(typeof(CsvColumnOrderAttribute), false))
                                            .Select(p => new {
                                                Order = ((CsvColumnOrderAttribute)Attribute.GetCustomAttribute(p, typeof(CsvColumnOrderAttribute))).Order,
                                                Prop = p
                                            })
                                            .OrderBy(p => p.Order)
                                            .Select(p => p.Prop)
                                            .ToArray();

            //в итоге сохраняем в _properties все свойства: сначала явно упорядоченные, затем - остальные, упорядоченные по имени
            _properties = explicitOrderedProps.Concat(props.Except(explicitOrderedProps).OrderBy(p => p.Name))
                                              .ToArray();
        }


        public CsvSerializer()
            : this(DefaultSeparatorCharacter, Encoding.Default)
        {
        }

        public CsvSerializer(char separatorCharacter)
            : this(separatorCharacter, Encoding.Default)
        {
            _separatorCharacter = separatorCharacter;
        }

        public CsvSerializer(Encoding encoding)
            : this(DefaultSeparatorCharacter, encoding)
        {
            _encoding = encoding;
        }

        public CsvSerializer(char separatorCharacter, Encoding encoding)
        {
            if (encoding == null)
                throw new ArgumentNullException();

            _separatorCharacter = separatorCharacter;
            _encoding = encoding;

            _seperatorBytes = _encoding.GetBytes(new[] { _separatorCharacter });
            _newLineBytes = _encoding.GetBytes(Environment.NewLine);
        }

        public char SeparatorCharacter
        {
            get
            {
                return _separatorCharacter;
            }
        }

        public Encoding SerializerEncoding
        {
            get
            {
                return _encoding;
            }
        }

        public void Serialize(Stream inputStream, IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                //для каждого свойства типа выполняем сериализацию его значения
                foreach (var property in CsvSerializer<T>._properties)
                {
                    //для этого нужно получить само значение
                    var value = property.GetValue(item, null);

                    //затем - его строковое представление
                    var strVal = CsvSerializer<T>.GetInvariantStrValue(value);

                    //преобразовать его в массив байт
                    byte[] buffer = _encoding.GetBytes(strVal);

                    //который записывается в поток
                    inputStream.Write(buffer, 0, buffer.Length);

                    //также записывается символ-разделитель колонок
                    inputStream.Write(_seperatorBytes, 0, _seperatorBytes.Length);
                }

                //по окончании обхода всех свойств типа выполняем переход на следующую строку - 
                //будет сериализован следующий объект
                inputStream.Write(_newLineBytes, 0, _newLineBytes.Length);
            }
        }

        public IEnumerable<T> Deserialize(Stream outputStream)
        {
            using (var reader = new StreamReader(outputStream, _encoding))
            {
                while (!reader.EndOfStream)
                {
                    //разделяем строку csv по разделителю
                    var cells = reader.ReadLine().Split(new[] { this.SeparatorCharacter }, StringSplitOptions.RemoveEmptyEntries);

                    //если количество столбцов не совпадает с количеством сериализуемых свойств
                    //скорее всего, что-то не так, выбрасываем исключение
                    if (cells.Length != _properties.Length)
                    {
                        throw new SerializationException();
                    }

                    var obj = new T();

                    //получаем значения всех свойств из ячеек
                    for (int i = 0; i < cells.Length; i++)
                    {
                        _properties[i].SetValue(obj, GetValueFromString(_properties[i].PropertyType, cells[i]), null);
                    }

                    yield return obj;
                }
            }
        }

        private static object GetValueFromString(Type type, string str)
        {
            //этот метод существенно упрощён, так, например, требуется особая логика для обработки массивов

            //в случае если тип - примитивный 
            if (type.IsPrimitive)
            {
                //задача - вызвать метод Parse для примитивного типа - Int16, Double, In32, etc.
                //можно напиать множество if'ов, но можно поступить так:
                //Считая, что у каждого примитивного типа есть метод Parse
                //просто получить его через reflection во время выполнения, передать необходимые параметры и вызвать


                return type.GetMethods().Single(m => {
                    var parameters = m.GetParameters();
                    var parametersValid = parameters.Length == 2 && parameters[1].ParameterType == typeof(IFormatProvider);
                    return m.Name == "Parse" && parametersValid;
                }).Invoke(null, new object[] { str, CultureInfo.InvariantCulture.NumberFormat });
            }

            if (type == typeof(DateTime))
            {
                return DateTime.Parse(str, CultureInfo.InvariantCulture.DateTimeFormat);
            }

            return str;
        }

        private static string GetInvariantStrValue(object value)
        {
            var strVal = value.ToString();

            if (value is DateTime || value is Double || value is Single)
            {
                strVal = (string)value.GetType().GetMethods().Single(m => {
                    var parameters = m.GetParameters();
                    var parameterValid = parameters.Length == 1 && parameters[0].ParameterType == typeof(IFormatProvider);
                    return m.Name == "ToString" && parameterValid;
                }).Invoke(value, new[] { CultureInfo.InvariantCulture.NumberFormat });

            }

            return strVal;
        }
    }
}