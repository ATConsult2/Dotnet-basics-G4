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
            // ------------ LINQ --------------
            PrintCollection(alist2);
            var result = from int d in alist2
                         where d > -10 
                         orderby d descending

                         select d;
            PrintCollection(result);
        }
    }
}
