using System;
using System.Collections.Generic;

namespace v4lab6
{
    public sealed class Library
    {
        public void Add(Book book)
        {
            throw new NotImplementedException("");
        }

        public IEnumerable<Book> Books
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException("");
        }

        public void Remove(string isbn)
        {
            throw new NotImplementedException("");
        }

        public IEnumerable<Book> Search(Predicate<Book> predicate)
        {
            throw new NotImplementedException("");
        }

        public IEnumerable<Book> Search(params string[] keywords)
        {
            throw new NotImplementedException("");
        }
    }
}
