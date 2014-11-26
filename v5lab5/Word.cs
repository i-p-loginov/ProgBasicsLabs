using System;
using System.Collections.Generic;

namespace v5lab5
{
    public class Word
    {
        /// <summary>
        /// Корни слова в порядке их следования.
        /// </summary>
        public IEnumerable<string> Roots
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Предкоренные части слова в порядке их следования.
        /// Возможно, следует определить типы, описывающие конкретные части слова.
        /// </summary>
        public IEnumerable<string> Prefixes
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Посткоренные части слова в порядке их следования.
        /// Возможно, следует определить типы, описывающие конкретные части слова (окончания, суффиксы, etc.)
        /// </summary>
        public IEnumerable<string> Postfixes
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Добавляет корень слова.
        /// </summary>
        /// <param name="root">Корень.</param>
        public void AddRoot(string root)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Добавляет предкоренную часть слова.
        /// </summary>
        /// <param name="preRootPart"></param>
        public void AddPrefix(string preRootPart)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Добавляет посткоренную часть слова.
        /// </summary>
        /// <param name="postrootPart"></param>
        public void AddPostfix(string postrootPart)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Проверяет, являются ли слова однокоренными.
        /// </summary>
        /// <param name="word">Слово для сравнения с этим экземпляром.</param>
        /// <returns></returns>
        public bool HasSameRoots(Word word)
        {
            throw new NotImplementedException("");
        }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
