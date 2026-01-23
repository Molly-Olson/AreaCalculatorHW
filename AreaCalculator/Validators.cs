using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public static class Validators
    {
        public static bool IsMinimumLength(string value, int min)
        {
            return value.Length >= min;
        }

        public static bool ContainsInteger(string value, out int number)
        {
            return int.TryParse(value, out number);
        }
    }
}
