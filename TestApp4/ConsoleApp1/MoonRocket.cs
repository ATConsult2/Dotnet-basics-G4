using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning2022.krasn.space
{
    internal class MoonModule
    {
        public string Name { internal set; get; }
        public MoonModule(string name)
        {
            Name = name;
        }

            /// data:  mass, power, chassie, ....
    }

    internal class MoonRocket:Rocket
    {
        public MoonModule Module { get; private set; }  // composition
       
        public MoonRocket(int mass, int power, MoonModule module):base(mass,power) { 
        Module = module;    
        }

        //public new void Ignit() {
        public override void Ignit() {
        WriteLine($"Moon module \"{Module.Name}\" launched!");
        }
        public override string ToString() {

            return 
                (base.ToString() + $"\b, Module: {Module.Name}.").
                Insert(0,"Moon ");
        }


    }
}
