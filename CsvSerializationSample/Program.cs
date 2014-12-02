using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CsvSerializationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<Person>();

            //заполняем список экземплярами класса Person со случайными значениями
            for (int i = 0; i < 100; i++)
            {
                lst.Add(new Person { Age = i, Name = Path.GetRandomFileName(), Birthday = DateTime.Now.AddYears(-1 * i) });
            }

            const string path = "sample.csv";

            //открываем поток, в который будет записываться состояние объектов
            using (var writer = new StreamWriter(path))
            {
                //создаём сериалайзер для типа Person
                var serializer = new CsvSerializer<Person>();

                //сериализуем в наш поток коллекцию Person'ов
                serializer.Serialize(writer.BaseStream, lst);
                
                writer.Close();
            }
            
            //открываем поток, в который будет прочитано содержимое csv-файла
            using (var reader = new StreamReader(path))
            {
                var serializer = new CsvSerializer<Person>();
             
                //выполняем десериализацию
                lst = serializer.Deserialize(reader.BaseStream).ToList();
            }

            //выводим все элементы коллекции
            Console.WriteLine(string.Join(Environment.NewLine, lst));
            Console.ReadKey();
        }
    }
}
