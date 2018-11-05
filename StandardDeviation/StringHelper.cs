using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation
{
    public class StringHelper
    {
        public string GetSubString(string input, char delimiter)
        {
            return string.Join(delimiter.ToString(),
                               input.Split(delimiter).Last());
        }
    }
}
