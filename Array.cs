using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Array
    {
        public void SumArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;

            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of array is: "+sum);
        }
    }
}
