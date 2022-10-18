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
            Engine3 engine33 = new Engine3("ccc-11-jj", 300_000, 442_444);
            WriteLine(engine33.getInfo());

            //5
            Engine4 engine44 = new Engine4("kkk-789-la", 333_000, 972_444);
            WriteLine(engine44.getInfo());

            //5
            Engine5 engine55 = new Engine5("jjh-543-la", 333_000, 972_444);
            WriteLine(engine55.getInfo());
            WriteLine(engine55);
            //Engine5.FACTORY = "1111"; const!!!
            new Engine5("jjh-543-la", 333_000, 972_444);

            // TEST value type, ref type
            DataClass dc1 = new DataClass { Name = 100 };
            DataClass dc2 = dc1;
            dc2.Name = 500;
            WriteLine(dc1 + "---" + dc2);
            //--------
            WriteLine("---------------------------------");
            DataStruct ds1 = new DataStruct { Name = 100 };
            DataStruct ds2 = ds1;
            ds2.Name = 500;
            WriteLine(ds1 + "---" + ds2);





        }
    }
}
