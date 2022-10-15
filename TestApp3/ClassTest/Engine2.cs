using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.fact
{
    public class Engine2
    {
        private string _model;
        private int _mass;
        private int _power;

        public string Model { 
        get {   //...
                return _model.ToUpper(); 
            }
        set { 
                // if......
                _model = value;
            } 
        }

        public int Power { 
        get { return _power; }
        set { _power = value; } 
        }

        public int Mass { 
        get { return _mass; }
        set { _mass = value; }  
        }

        public Engine2() {
            WriteLine("+++ ctor Engine2.");
        }

        public string getInfo() {
            return $"Engine {Model}, Power: {Power}, Mass: {Mass}.";
        }

    }
}
