using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class CountPositive
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { -4, 2, 0, 2 };
            int result = countPositive(inputArray);
            Console.WriteLine("Expected result is 2, actual result is " + result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // If x==null throw NullPointerException
        // else return the number of positive elements in x.
        static int countPositive(int[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0) // only positive elements not including 0s
                {
                    count++;
                }
            }
            return count;
        }
    }
}
