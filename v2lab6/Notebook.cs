﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace v2lab6
{
    public sealed class NoteBook
    {
        private readonly List<Contact> _contacts = new List<Contact>();

        public IEnumerable<Contact> Contacts
        {
            get
            {
                throw new NotImplementedException("");
            }
        }

        public void Add(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();


            throw new NotImplementedException("");
        }

        public void Remove(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            throw new NotImplementedException("");
        }

        public IEnumerable<Contact> Search(Predicate<Contact> predicate)
        {
            throw new NotImplementedException("");
        }
    }
}
