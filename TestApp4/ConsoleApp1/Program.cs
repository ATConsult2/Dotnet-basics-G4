using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{

    
    internal class Program
    {
        static void SingletonTest() {
            Singleton s1 = Singleton.getInstance();
            WriteLine(s1.GetHashCode());
            Singleton s2 = Singleton.getInstance();
            WriteLine(s2.GetHashCode());
        }

        static void PintaTest() {
            Pinta p1 = Pinta.getBeer();
            Pinta p2 = Pinta.getBeer(0);
            Pinta p3 = Pinta.getBeer(1);
            Pinta p4 = Pinta.getBeer(2);
            Pinta p5 = Pinta.getBeer(5);
            WriteLine($"{p2.I} -  {p3.I} - {p5?.I}");
        }

        static void Main(string[] args)
        {
            // SingletonTest();
            // PintaTest();

        }
    }
}
