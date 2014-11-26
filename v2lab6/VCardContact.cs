using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v2lab6
{
    public class VCardContact
    {
        private VCardContact()
        {
            throw new NotImplementedException("");
        }

        public VCardContact(Contact contact)
        {
            throw new NotImplementedException("");
        }

        public string FormattedName { get; private set; }

        public string Name { get; private set; }

        public string Nickname { get; private set; }

        public DateTime Birthday { get; private set; }

        public string Phone { get; private set; }

        public string Email { get; private set; }

        public string Note { get; private set; }

        public Contact ToContact()
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
