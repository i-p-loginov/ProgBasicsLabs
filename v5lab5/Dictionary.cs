using System;
using System.Collections.Generic;

namespace v5lab5
{
    public class Dictionary
    {
        /// <summary>
        /// Коллекция всех слов, сгрупированных по корням и упорядоченных по возрастанию количества словообразующих частей
        /// </summary>
        public IEnumerable<Word> Words
        {
            get
            {
                throw new NotImplementedException("");
            }
        }
        
        /// <summary>
        /// Добавляет слово в словарь
        /// </summary>
        /// <param name="word"></param>
        public void Add(Word word)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Осуществляет поиск слов по корню
        /// </summary>
        /// <param name="root">Корень слова</param>
        /// <returns></returns>
        public IEnumerable<Word> Search(string root)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Удаляет слово из словаря.
        /// </summary>
        /// <param name="word"></param>
        public void Remove(Word word)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Удаляет слова с заданным корнем.
        /// </summary>
        /// <param name="root"></param>
        public void RemoveByRoot(string root)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Проверяет наличие слова в словаре.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Contains(string word)
        {
            throw new NotImplementedException("");
        }
    }
}
