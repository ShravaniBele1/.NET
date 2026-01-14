using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Factorial
    {
        public void Fact(int num)
        {
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial: "+fact);
        }
        
    }
}
