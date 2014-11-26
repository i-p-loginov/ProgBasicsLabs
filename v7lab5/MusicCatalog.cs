using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v7lab5
{
    public sealed class MusicCatalog
    {
        /// <summary>
        /// Коллекция песен в каталоге.
        /// </summary>
        public IEnumerable<Song> Songs
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        /// <summary>
        /// Добавляет песню в каталог.
        /// </summary>
        /// <param name="song"></param>
        public void Add(Song song)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Удаляет песню из каталога.
        /// </summary>
        /// <param name="song"></param>
        public void Remove(Song song)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Выполняет поиск песен в соответствии с критерием.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Song> Search(Predicate<Song> predicate)
        {
            throw new NotImplementedException("");
        }
    }
}
