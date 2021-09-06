using System.Globalization;
using System.IO;
using System;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace VagabondCsv
{
    public class ReadingCsvWithBooleans
    {
        public static void Start()
        {
            using(var reader = new StreamReader("csvfiles/simple.csv"))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Foo>();

                foreach (var record in records)
                {
                    Console.Write(record.Id.ToString());
                    Console.Write(", ");
                    Console.Write(record.Name.ToString());
                    Console.Write(", ");
                    Console.Write(record.IsSomething.ToString());
                    Console.WriteLine();
                }
            }
        }
    }

    public class Foo
    {
        [Name("Id")]
        public int Id { get; set; }

        [Name("Name")]
        public string Name { get; set; }

        [Name("IsSomething")]
        public bool? IsSomething { get; set; }
    }
}
