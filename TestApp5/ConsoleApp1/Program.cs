using System;
using System.Collections.Generic;
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


        static void Main(string[] args)
        {
           Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");    

            Balloon b1 = new Balloon(r:1);
            Balloon b2 = new Balloon(r:2.00000002);

            // test ==
            WriteLine(b1 == b2);

            Balloon b3 = b1 + b2;
            WriteLine(b3);
            ++b3;++b3;
            WriteLine(b3);

            Basket basket = new Basket(
                new Balloon[] {b1,b2,b3}                
                );

            WriteLine(basket[1]);
            WriteLine(basket["two"]);


            // ---------------------------------
            Gen<int> g1 = new Gen<int> { Value = 1 };  // restrictions!!!
            WriteLine("----------- swap test ----------");
            WriteLine(b1 + " --- " + b3);
            swap(ref b1, ref b3);
            WriteLine(b1 + " --- " + b3);



        }
    }
}
