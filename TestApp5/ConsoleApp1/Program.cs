using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;


namespace andestech.learning2022.krasn
{

    class Gen<T> { 
     public T Value { get; set; }
    
    }

    internal class Program
    {
        //(x,y) = (y,x)
        static void swap<T>(ref T a, ref T b) {
            T o = a; a = b; b = o;
        }

        static void BalloonTest() { 

            Balloon b1 = new Balloon(r: 1);
            Balloon b2 = new Balloon(r: 2.00000002);

            // test ==
            WriteLine(b1 == b2);

            Balloon b3 = b1 + b2;
            WriteLine(b3);
            ++b3; ++b3;
            WriteLine(b3);

            Basket basket = new Basket(
                new Balloon[] { b1, b2, b3 }
                );

            WriteLine(basket[1]);
            WriteLine(basket["two"]);


            // ---------------------------------
            Gen<int> g1 = new Gen<int> { Value = 1 };  // restrictions!!!
            WriteLine("----------- swap test ----------");
            WriteLine(b1 + "\t --- " + b3);
            swap(ref b1, ref b3);
            WriteLine(b1 + "\t --- " + b3);

        }

        static void PrintCollection(IEnumerable datas)
        {
            //if (((ICollection)datas).Count == 0) { Write("{}"); return; } 
            Write("{"); 
            foreach (var d in datas) Write(d + ", ");
            Write("\b\b}\n");
        }

        static void Main(string[] args)
        {
           Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // BalloonTest();
           ArrayList alist = new ArrayList(4) { 1,4, "ee", new Balloon(10), -1000};
           PrintCollection(alist);
           ArrayList alist2 = new ArrayList() {
           1,2,3-4,-20,5,22,34,66,-5 };
           PrintCollection(alist2);
            alist2.Add(101);
            alist2.AddRange(new ArrayList() { -7, -8, 4 });
           PrintCollection(alist2);
            WriteLine(alist2.Capacity + "  ----  " + alist2.Count);
            WriteLine(alist2[5]);
            alist2.AddRange(new ArrayList() { -200,-120,-137, 138 });
            WriteLine(alist2.Capacity + "  ----  " + alist2.Count);
            WriteLine("=======================================");
            // ------------ LINQ -------------- 1
            PrintCollection(alist2);
            var result = (from int d in alist2
                          where d > -10
                          orderby d descending
                          select d).ToList();
            PrintCollection(result);
            Func<int, int, int> F1 = (x, y) => x - y;
            result.Sort((x, y) => Math.Abs(x) - Math.Abs(y));
            PrintCollection(result);
            var result2 = result.Where(x => x < 50);
            WriteLine("---------- result2 ----------");
            PrintCollection(result2);
            PrintCollection(alist2);

            WriteLine("---------- Generic Collection ----------");

            List<Balloon> balloons = new List<Balloon>();

            balloons.Add(new Balloon(1));
            balloons.Add(new Balloon(10));
            balloons.Add(new Balloon(4));
            balloons.Add(new Balloon(100));

            balloons.Insert(2, new Balloon(50));
            PrintCollection(balloons);
            balloons.Sort();
            PrintCollection(balloons);

            //-----------------------------  
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            PrintCollection(stack);
            stack.Pop();
            PrintCollection(stack);
            WriteLine("---------------------------------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            PrintCollection(queue);
            queue.Dequeue();
            PrintCollection(queue);
            WriteLine("---------------------------------");
            Dictionary<int, string> dict
                = new Dictionary<int, string> {
                    {1, "wwww" },
                    { -20, "HI!!"},
                    { 2, "Hello!"}

                };
            foreach (int key in dict.Keys)
            {
                WriteLine($"{key} --> {dict[key]}");
            }

            var dict2 = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key);
            WriteLine("---------------------------------");
            foreach (int key in dict2.Keys)
            {
                WriteLine($"{key} --> {dict2[key]}");
            }

        }
    }

    internal class MySort : IComparer
    {
        public int Compare(object x, object y)
        {
            return Math.Abs((int)y) - Math.Abs((int)x);
        }
    }
}
