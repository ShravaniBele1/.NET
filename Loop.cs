using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Loop
    {
        public void Ifelse()
        {
            if (10 > 5)
                Console.WriteLine("true");
            else if (10 < 5)
                Console.WriteLine("false");
            else
                Console.WriteLine("equal");
        }

        public void For()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
