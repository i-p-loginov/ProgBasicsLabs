using System;

namespace CsvSerializationSample
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class CsvNonSerializableAttribute : Attribute
    {   
    }
}
