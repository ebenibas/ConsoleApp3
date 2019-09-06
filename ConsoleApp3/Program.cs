using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        //  array[0..n-1] with sum

        static void getGroup(int[] array,
                               int n, int sum)
        {

            // calculate the sum by checking group or pairs
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (array[i] + array[j] == sum)
                        Console.Write("(" + array[i] + ", " + array[j] + ")"
                                      + "\n");
            Console.ReadLine();
        }

        public static void Main()
        {
            int[] array = { 1, 4, 8, 6, 5 };
            int n = array.Length;
            int sum = 7;
            getGroup(array, n, sum);
            Console.ReadLine();
        }
    }

}
