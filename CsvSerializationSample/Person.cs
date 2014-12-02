using System;

namespace CsvSerializationSample
{
    public class Person
    {
        //[CsvNonSerializable]
        public string Name { get; set; }

        public double Age { get; set; }

        [CsvColumnOrder(2)]
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}), bday: {2:dd.MM.yyyy}", Name, Age, Birthday);
        }
    }
}
