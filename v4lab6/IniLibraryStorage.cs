using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;

namespace v4lab6
{
    public sealed class IniLibraryStorage
    {
        public IniLibraryStorage()
        {
            this.Books = new ReadOnlyCollection<BookIniModel>(Enumerable.Empty<BookIniModel>().ToArray());
        }

        public IniLibraryStorage(Library library)
        {
            if (library == null)
                throw new ArgumentNullException();

            BookIniModel[] iniBooks = library.Books.Select(b => new BookIniModel(b)).ToArray();

            this.Books = new ReadOnlyCollection<BookIniModel>(iniBooks);
        }

        public ReadOnlyCollection<BookIniModel> Books
        {
            get;
            private set;
        }

        public void Save(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var book in this.Books)
                {
                    writer.WriteLine(book);
                }
            }
        }

        public void Load(string path)
        {
            List<BookIniModel> books = new List<BookIniModel>();

            //read books from ini here
            throw new NotImplementedException("");

            this.Books = new ReadOnlyCollection<BookIniModel>(books);
        }
    }
}
