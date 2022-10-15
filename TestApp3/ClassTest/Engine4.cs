using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.fact
{
    public class Engine4
    {
       public string Model { get; private set; } 
       public int Power { get; private set; }
       public int Mass { get; private set; } 
      
        private Engine4() {
            WriteLine("+++ ctor default Engine4.");
        }

        public Engine4(string Model, int Mass, int Power):this()
        {
            WriteLine("+++ ctor params Engine4.");
            this.Model = Model;
            this.Power = Power;
            this.Mass = Mass;
        }

        public string getInfo() {
            // Mass = 0; // !!!
            return $"Engine4 {Model}, Power: {Power}, Mass: {Mass}.";
        }

    }
}

