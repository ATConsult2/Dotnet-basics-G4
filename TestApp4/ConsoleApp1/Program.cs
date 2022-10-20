using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

using andestech.learning2022.krasn.space;

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

       // static void RocketTest(Rocket rocket)
         static void RocketTest(ILaunch rocket)
        {
            WriteLine(new string('+', 50));
            //....
            rocket.Ignit();
            //....
            WriteLine(rocket);

        }

        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // SingletonTest();
            // PintaTest();
           // Rocket r1 = new Rocket(power: 200_500, mass: 100_000);
            //WriteLine(r1);
           // r1.Ignit();

            MoonRocket r2 = new MoonRocket(power: 200_500, 
                mass: 100_000, module: new MoonModule("Apollo-13"));
            WriteLine(r2);
            r2.Ignit();
            WriteLine(new String('-', 50));

            Rocket r3 = new MoonRocket(power: 200_500,
                mass: 100_000, module: new MoonModule("Apollo-9"));
            WriteLine(r3);
            r3.Ignit();
            WriteLine(new String('-', 50));

            // type conversion test 
            object o = new MoonRocket(power: 200_500,
                mass: 100_000, module: new MoonModule("Apollo-3"));

            // MarsRocket mr1 = (MarsRocket)o; // !Cast Exception!
            Rocket mr1 = (Rocket)o;
            WriteLine(((MoonRocket)mr1).Module.Name);

            if (o is MarsRocket mr2) {
                mr2.Ignit();
            }

            if (o is Rocket mr3)
            {
                mr3.Ignit();
            }

            MarsRocket mr4 = o as MarsRocket;
            //mr4.Ignit(); // Null Ref Exception!!!
            if (mr4 != null) { mr4.Ignit(); }
            mr4?.Ignit();

            // Boxing & Unboxing
            int i2 = 1;
            Object o1 = i2;
            o1 = 10.111;
            WriteLine(i2 + " ---- " + o1);

            // -- poly test --
            RocketTest(new MoonRocket(power: 100_500,
                mass: 500_000, module: new MoonModule("Apollo-3")));
            RocketTest(new MarsRocket(power: 1000_500,
               mass: 5500_770, module: new MarsModule("Mars-10")));

        }
    }
}
