using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v4lab6
{
    public sealed class BookIniModel
    {
        public BookIniModel(Book book)
        {
            if (book == null)
                throw new ArgumentNullException();
            
            this.Book = book;
        }

        public Book Book
        {
            get;
            private set;
        }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
