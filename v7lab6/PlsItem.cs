using System;

namespace v7lab6
{
    public sealed class PlsItem
    {
        private const int UnresolvedLength = -1;

        public PlsItem(Song song, string path, int number)
        {
            if (song == null)
                throw new ArgumentNullException();

            if (path == null)
                throw new ArgumentNullException();

            if (number <= 0)
                throw new ArgumentOutOfRangeException("number");
            
            this.Song = song;
            this.File = path;
            this.Number = number;

            //не определено
            this.Length = PlsItem.UnresolvedLength;
        }

        private PlsItem()
        {
            throw new NotImplementedException("");
        }

        public int Number { get; private set; }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string File { get; private set; }

        /// <summary>
        /// Описание самой композиции
        /// </summary>
        public Song Song { get; private set; }

        /// <summary>
        /// Длина трека в секундах. 
        /// </summary>
        public int Length { get; private set; }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
