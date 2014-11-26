using System;
using System.Collections.Generic;

namespace v7lab6
{
    public class Playlist
    {
        public Playlist()
        {
            this.Catalog = new MusicCatalog();
        }

        public Playlist(MusicCatalog catalog)
        {
            throw new NotImplementedException("");
        }

        public MusicCatalog Catalog
        {
            get;
            private set;
        }

        public IEnumerable<PlsItem> PlsItems
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public void Add(PlsItem playlistItem)
        {
            throw new NotImplementedException("");
        }

        public void Add(Song song, string path)
        {
            throw new NotImplementedException("");
        }

        public void Remove(Song song)
        {
            throw new NotImplementedException("");
        }

        public void Load(string path)
        {
            throw new NotImplementedException("");
        }

        public void Save(string path)
        {
            throw new NotImplementedException("");
        }
    }
}
