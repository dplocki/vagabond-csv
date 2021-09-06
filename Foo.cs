using System;
using CsvHelper.Configuration.Attributes;

namespace VagabondCsv
{
    public class Foo
    {
        [Name("Id")]
        public int Id { get; set; }

        [Name("Name")]
        public string Name { get; set; }

        [Name("IsSomething")]
        public bool? IsSomething { get; set; }

        public void PrintContent()
        {
            Console.Write(Id.ToString());
            Console.Write(", ");
            Console.Write(Name.ToString());
            Console.Write(", ");
            Console.Write(IsSomething.ToString());
            Console.WriteLine();
        }
    }
}
