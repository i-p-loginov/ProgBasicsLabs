using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvSerializationSample
{
    /// <summary>
    /// Этот атрибут устанавливает порядок, в котором элементы класса будут сериализованы в соответствующие столбцы в csv-документе.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class CsvColumnOrderAttribute : Attribute
    {
        /// <summary>
        /// Инициализирует экземпляр класса этого атрибута, задавая порядковый номер (слева направо) столбца для свойства.
        /// </summary>
        /// <param name="order"></param>
        public CsvColumnOrderAttribute(int order)
        {
            this.Order = order;
        }

        /// <summary>
        /// Предоставляет информацию о порядке расположения столбца.
        /// </summary>
        public int Order { get; private set; }
    }
}
