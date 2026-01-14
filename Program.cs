using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Addition add = new Addition();
            int result = add.Add(5, 10);

            Console.WriteLine("Sum:" + result);

            Arithmetic addition = new Arithmetic();
            int Add = addition.Add(10, 5);
            Console.WriteLine("Sum:" + result);

            Arithmetic subtraction = new Arithmetic();
            int sub = subtraction.Sub(10, 5);
            Console.WriteLine("Sub:" + result);

            Arithmetic multiplication = new Arithmetic();
            int mul = subtraction.Mul(10, 5);
            Console.WriteLine("Mul:" + result);

            Arithmetic division = new Arithmetic();
            int div = division.Div(10, 5);
            Console.WriteLine("Div:" + result);

            Loop ifelse = new Loop();
            ifelse.Ifelse();

            Loop forloop = new Loop();
            forloop.For();

            Factorial fact = new Factorial();
            fact.Fact(4);

            Array sum=new Array();
            sum.SumArray();
        }       
    }
}
