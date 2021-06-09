using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpl.Examples
{
    class Program
    {

        static void MethodA()
        {
            Console.WriteLine("This is methodA");
        }

        static void MethodB()
        {
            Console.WriteLine("This is methodB");
        }

        static void Main(string[] args)
        {

            Task taskA = Task.Factory.StartNew(MethodA);
            Task taskB = Task.Factory.StartNew(MethodB);

            for(int i= 0; i < 100; i++)
            {
                Console.WriteLine("This principal " + i);
            }
            

        }
    }
}
