using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning2022.krasn.space
{
    internal class MarsModule
    {
        public string Name { internal set; get; }
        public MarsModule(string name)
        {
            Name = name;
        }

            /// data:  mass, power, chassie, ....
    }

    internal class MarsRocket:Rocket
    {
        public MarsModule Module { get; private set; }  // composition
       
        public MarsRocket(int mass, int power, MarsModule module):base(mass,power) { 
        Module = module;    
        }

        public override void Ignit()
        {
            WriteLine($"Mars module \"{Module.Name}\" launched!");
        }
        public override string ToString()
        {
            
            return
                (base.ToString() + $"\b, Module: {Module.Name}.").
                Insert(0, "Mars ");
        }

    }
}
