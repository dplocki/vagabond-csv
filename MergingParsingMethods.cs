using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace VagabondCsv
{
    public class MergingParsingMethods
    {
        public static void Start()
        {
            using(var reader = new StreamReader("csvfiles/simple_with_additional_columns.csv"))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while(csv.Read())
                {
                    var foo = csv.GetRecord<Foo>();

                    foo.PrintContent();
                    Console.Write("Column count: ");
                    Console.WriteLine(csv.ColumnCount.ToString());
                }
            }
        }
    }
}