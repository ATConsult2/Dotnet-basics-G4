using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.space
{
    internal abstract class Rocket : ILaunch
   // internal class Rocket
    {
        public int Mass { get; private set; }
        protected int Id { get; private set; }  
        protected int Power { get; private set; }
        private static Random random = new Random();    
        public Rocket(int mass, int power)
        {
            Id = random.Next(1000000);
            Mass = mass;
            Power = power;
        }

        /* public virtual void Ignit() {
             WriteLine($"Rocket {GetHashCode()} ignited. Поехали!");
         }*/

        public abstract void Ignit();
        public override string ToString()
        {
            return $"Rocket M-->{Mass}, P-->{Power}.";
        }
    }
}
