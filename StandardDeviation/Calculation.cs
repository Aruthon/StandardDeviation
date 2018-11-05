using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation
{
    public class Calculation
    {
        public double CalculateSD(IEnumerable<int> values)
        {
            double result = 0;
            if (values.Count() > 0)
            {
                double avg = values.Average();
                double sum = values.Sum(d => Math.Pow(d - avg, 2));
                result = Math.Sqrt((sum) / (values.Count() - 1));
            }
            return result;
        }
    }
}
