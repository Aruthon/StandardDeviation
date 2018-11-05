using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation
{
    class Program 
    {
        static void Main(string[] args)
        {
            StringHelper stringHelper = new StringHelper();
            Calculation calculation = new Calculation();

            List<string> yearList = new List<string>();                     
            List<int> valuesList = new List<int>();
     
            ReadFile(yearList);

            foreach (var item in yearList)
            {
                var values = stringHelper.GetSubString(item, '#');
                valuesList.Add(Int32.Parse(values));
            }

            var result = calculation.CalculateSD(valuesList);

            Console.WriteLine("Standard Deviation is: " + result);

            Console.WriteLine("Enter a key to close.");
            Console.ReadKey();
        }


        private static void ReadFile(List<string> yearList)
        {
            try
            {

                string[] lines = System.IO.File.ReadAllLines(Definitions.FILE);

                foreach (string line in lines)
                {
                    if (line.Contains("2000"))
                    {
                        yearList.Add(line);
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(Definitions.ERROR + e);
                throw;
            }
        }     
             
    }
}
