using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.fact
{
    public class Engine3
    {
        private string _model;
        private int _mass;
        private int _power;

        public string Model { 
        get {   //...
                return _model.ToUpper(); 
            }
        private set { 
                // if......
                _model = value;
            } 
        }

        public int Power { 
        get { return _power; }
        private set { _power = value; } 
        }

        public int Mass { 
        get { return _mass; }
        private set { _mass = value; }  
        }

        private Engine3() {
            WriteLine("+++ ctor default Engine3.");
        }

        public Engine3(string Model, int Mass, int Power):this()
        {
            WriteLine("+++ ctor params Engine3.");
            this.Model = Model;
            this.Power = Power;
            this.Mass = Mass;
        }

        public string getInfo() {
            return $"Engine {Model}, Power: {Power}, Mass: {Mass}.";
        }

    }
}
