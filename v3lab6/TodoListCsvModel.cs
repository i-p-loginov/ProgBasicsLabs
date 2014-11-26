using System;
using System.Collections.Generic;
using System.IO;

namespace v3lab6
{
    public sealed class TodoListCsvModel
    {
        //в таком виде можно хранить модель, готовую к сохранению или загрузке
        private readonly List<List<string>> _csvStrings = new List<List<string>>();

        public TodoListCsvModel(TodoList todoList)
        {
            if (todoList == null)
                throw new ArgumentNullException();

            this.TodoList = todoList;
        }

        public TodoList TodoList
        {
            get;
            private set;
        }

        /// <summary>
        /// Сохраняет TodoList в csv-документ.
        /// </summary>
        /// <param name="path">Путь к файлу, в который будет сохранён TodoList.</param>
        public void Save(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var task in this.TodoList.Tasks)
                {
                    writer.WriteLine(TodoListCsvModel.GetCsvStringTask(task));
                }
            }
        }

        /// <summary>
        /// Загружает содержимое csv-документа из файла.
        /// </summary>
        /// <param name="path">Путь к файлу в формате csv.</param>
        public void Load(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var model = new TodoList();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                }
            }
        }

        /// <summary>
        /// Возвращает строковое представление одной задачи в формате csv.
        /// </summary>
        /// <param name="task">Задача, которую необходимо преобразовать в строку.</param>
        /// <returns>Строка в формате csv.</returns>
        private static string GetCsvStringTask(Task task)
        {
            //внимание! Нужно внимательно следить за соответствием формата строки,
            //возвращаемой этим методом, и форматом строки, передаваемой в метод GetTaskFromCsv
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Возвращает экземпляр Task, полученный из строкового представления в формате csv.
        /// </summary>
        /// <param name="csvString">Строка, содержащее представление объекта Task в формате csv.</param>
        /// <returns>Экзепляр Task.</returns>
        private static Task GetTaskFromCsv(string csvString)
        {
            throw new NotImplementedException("");
        }
    }
}
