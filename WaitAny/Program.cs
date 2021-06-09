using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitAny
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

            var tasks = new Task[] { taskA, taskB };

            Console.WriteLine("Se inicia la espera de la task a o la tarea b");

            Task.WaitAny(tasks);

            Console.WriteLine("Se finaliza la espera de la task a o la tarea b");


            Console.WriteLine("Task A id " + taskA.Id);
            Console.WriteLine("Task B id " + taskB.Id);


        }
    }
}

