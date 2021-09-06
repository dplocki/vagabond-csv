using System;

namespace VagabondCsv
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MergingParsingMethods");
            MergingParsingMethods.Start();
            
            Console.WriteLine();
            Console.WriteLine("ReadingCsvWithBooleans");
            ReadingCsvWithBooleans.Start();
        }
    }
}
