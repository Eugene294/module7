using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    static class IntExtensions
    {
        public static int GetNegative(this int number)
        {
            if (number > 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
        public static int GetPositive(this int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
    }


}
