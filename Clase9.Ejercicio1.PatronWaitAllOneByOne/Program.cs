using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.Ejercicio1.PatronWaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10000;
            List<Task<int>> tareas = new List<Task<int>>();
            IDictionary<int, int> quiniela = new Dictionary<int, int>();
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                tareas.Add(Task.Factory.StartNew<int>(() =>
                {
                    return r.Next(0, 100);
                    }));
            }

            while(tareas.Count > 0)
            {
                int index = Task.WaitAny(tareas.ToArray());
                quiniela.Add(tareas[index].Id, tareas[index].Result);
                tareas.RemoveAt(index);
            }

            foreach(KeyValuePair<int, int> q in quiniela)
            {
                Console.WriteLine("Id de tarea: " + q.Key + " Numero generado: " + q.Value);
            }

        }
    }
}
