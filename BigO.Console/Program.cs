using BigO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> collections;

            int[] list = {100, 1000, 10000, 100000};
            List<int> sizes = new List<int>();
            sizes.AddRange(list);

            Console.WriteLine("Be patient, we are creating collections...");                
            collections = GetCollectionsWithSizes(sizes);
            Console.WriteLine("Collections created");

            Console.WriteLine("{0, -10} {1, 20:N} {2, 28:N} ", "Order", "Size", "Time (seconds)");
            Execute(new ConstantOrder(), collections);
            Execute(new LinearOrder(), collections);
            Execute(new CuadraticOrder(), collections);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Execute(ComplexityOrder element, List<List<int>> collections)
        {
            foreach (var item in collections)
            {
                StopWatch watch = StopWatch.StartNew();
                element.Execute(item);
                Console.WriteLine("{0, -10} {1, 20:N} {2, 28:N} ", element.GetType().Name, item.Count, watch.ElapsedMilliseconds / 1000.0);
            }
            
            foreach (var item in collections)
            {
                StopWatch watch = StopWatch.StartNew();
                element.ExecuteMultipleOperations(item);
                Console.WriteLine("{0, -10} MultOps {1, 20:N} {2, 28:N} ", element.GetType().Name, item.Count, watch.ElapsedMilliseconds / 1000.0);
            }
        }

        public static List<List<int>> GetCollectionsWithSizes(List<int> sizes)
        {
            List<List<int>> collections = new List<List<int>>();


            foreach (var item in sizes)
            {
                List<int> collection = new List<int>();
                for (int i = 0; i < item; i++)
                {
                    collection.Add(new Random().Next(5000));
                }
                collections.Add(collection);
            }

            return collections;
        }
    }
}
