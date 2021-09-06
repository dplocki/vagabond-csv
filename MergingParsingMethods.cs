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
                csv.Read();
                csv.ReadHeader();

                while(csv.Read())
                {
                    var foo = csv.GetRecord<Foo>();

                    foo.PrintContent();
                    Console.WriteLine($"Column count {csv.Parser.Count}/{csv.HeaderRecord.Length}");

                    for(var index = csv.HeaderRecord.Length; index < csv.Parser.Count; index++) {
                        Console.WriteLine($"\t{csv.GetField(index).Trim()}");
                    }
                }
            }
        }
    }
}