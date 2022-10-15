using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using andestech.learning2022.krasn.fact;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Engine engine = new Engine();
            //1
            engine.Power = 1000_000;
            engine.Model = "AAA-22-B";
            engine.Mass = 500_000;
            WriteLine(engine.getInfo());
            //2
            Engine engine2 = new Engine
            { Model="AAA-33-J",Mass=200_000,Power=222_444};
            WriteLine(engine2.getInfo());

            //3
            Engine2 engine22 = new Engine2
            { Model = "BBB-33-J", Mass = 500_000, Power = 772_444 };
            WriteLine(engine22.getInfo());

            //4
            Engine3 engine33 = new Engine3("CCC-11-J", 300_000, 442_444);
            WriteLine(engine33.getInfo());

            new Engine();
            


        }
    }
}
