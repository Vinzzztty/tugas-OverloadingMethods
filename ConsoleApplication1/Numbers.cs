using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if (number1 > number2)
                return number2;
            else if (number1 < number2)
                return number1;
            return 0;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            if (number1 < number2 && number1 < (int)number3)
                return number1;
            else if (number2 < number1 && number2 < (int)number3)
                return number2;
            else if ((int)number3 < number1 && (int)number3 < number2)
                return (int)number3;

            return 0;
        }

        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            else if (number1 < number2)
                return number2;
            return 0;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            if (number1 > number2 && number1 > (int)number3)
                return number1;
            else if (number2 > number1 && number2 > (int)number3)
                return number2;
            else if ((int)number3 > number1 && (int)number3 > number2)
                return (int)number3;

            return 0;
        }
    }
}
