using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// V03
namespace LINQ01
{
    // For Convert To Extension Method.
    // 1. Must To Be in A class [static],And Non Generic .
    // 2. In Return Data Type [this]
    internal static class IntExtension
    {
        // 1234
        public static int Reverse(this int Num)
        {
            int RevNum = 0, LastDigit;
            while (Num > 0)
            {
                LastDigit = Num % 10;
                RevNum = RevNum * 10 + LastDigit;
                Num /= 10;
            }
            return RevNum;
        }


        public static long Reverse(this long Num)
        {
            long RevNum = 0, LastDigit;
            while (Num > 0)
            {
                LastDigit = Num % 10;
                RevNum = RevNum * 10 + LastDigit;
                Num /= 10;
            }
            return RevNum;
        }


        // 4321
        /*
          12345
        12345 % 10 = 5
        12345 / 10 = 1234
        1234 % 10 = 4
        1234 / 10 = 123
        123 % 10 = 3
        123 / 10 = 12
        12 % 10 = 2
        12 / 10 = 1
        1 / 10 = 0


        RevNum = 5 
                 54
                 543
                 5432
                 54321.

        OutPut
         */
    }
}
