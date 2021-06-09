using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitAll
{
    class Program
    {

        static void MethodA()
        {
            Thread.SpinWait(int.MaxValue);
            Console.WriteLine("Tarea a");
        }

        static void MethodB()
        {
            Thread.SpinWait(int.MaxValue / 2);
            Console.WriteLine("Tarea b");
        }

        static void Main(string[] args)
        {

            Task taskA = Task.Factory.StartNew(MethodA);
            Task taskB = Task.Factory.StartNew(MethodB);

            Console.WriteLine("Task A id " + taskA.Id);
            Console.WriteLine("Task B id " + taskB.Id);

            var tasks = new Task [] {taskA};

            Task.WaitAll(tasks);

        }
    }
}
