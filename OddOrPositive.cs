using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class OddOrPositive
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { -3, -2, 0, 1, 4 };
            int result = oddOrPositive(inputArray);
            Console.WriteLine("Expected result is 3, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // If x==null throw NullPointerException
        // else return the number of elements in x that
        // are odd and/or positive
        static int oddOrPositive(int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0 || x[i] > 0) // % 2 != 0 checks for odd numbers properly
                {
                    count++;
                }
            }
            return count;
        }
    }
}
