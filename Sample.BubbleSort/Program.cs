using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Sample.BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {


         


           // Console.WriteLine(string.Join(",", b));

            int[] a = BubbleSort.GetBigArray();// new[]  { 30, 45, 43, 23, 45, 23, 546, 56 }; 


            TestBubbleSort(a);
            //  Console.WriteLine(string.Join(",", a));
            int[] b = BubbleSort.GetBigArray();// new[] { 30, 45, 43, 23, 45, 23, 546, 56 };
            TestQuickSort(b);



            Console.ReadKey();
        }

        private static void TestBubbleSort(int[] a)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubbleSort.Sort(a);
            sw.Stop();
            Console.WriteLine($"Time taken by {nameof(BubbleSort)} for array length of {a.Length}: {sw.ElapsedMilliseconds} ms.");
        }

        private static void TestQuickSort(int[] a)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSort.Sort(a, 0, a.Length - 1);
            sw.Stop();
            Console.WriteLine($"Time taken by {nameof(QuickSort)} for array length of {a.Length}: {sw.ElapsedMilliseconds} ms.");
        }
    }
}
