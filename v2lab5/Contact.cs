using System;

namespace v2lab5
{
    public class Contact
    {
        public string Nickname { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
