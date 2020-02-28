using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class LastZero
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 0, 1, 0 };
            int result = lastZero(inputArray);
            Console.WriteLine("Expected result is 2, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // If x==null throw NullPointerException
        // else return the index of the last 0 in x.
        // If 0 does not occur in x, return -1.
        static int lastZero(int[] x)
        {
            int lastIndex = -1; // Variable that will allow tracking the index of the last 0 found in x

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    lastIndex = i; // Set the last 0 found's index to the variable lastIndex
                }
            }
            return lastIndex; // this will return -1 if no 0 is found in x otherwise returns last 0's index
        }
    }
}
