using System.Globalization;
using System.IO;
using CsvHelper;

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
                    record.PrintContent();
                }
            }
        }
    }
}
