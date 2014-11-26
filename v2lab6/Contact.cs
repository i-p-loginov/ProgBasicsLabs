using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v2lab6
{
    public class Contact
    {
        public string Nickname { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public VCardContact ToVcard()
        {
            throw new NotImplementedException("");
        }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
