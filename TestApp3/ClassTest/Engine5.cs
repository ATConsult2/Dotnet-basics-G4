using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.fact
{
    public class Engine5 : Object
    {
       public const string FACTORY = "F22-GG-11-KRASNOYARSK";
       private readonly int id;

       public static readonly string StandID;

        static Engine5() {
            WriteLine("+++ STATIC ctor Engine5.");
            //...
            //...
            StandID = "YYY-54-HH";
        }


       public string Model { get; } 
       public int Power { get; }
       public int Mass { get; } 
      
        private Engine5() {
            WriteLine("+++ ctor default Engine5.");
        }

        public Engine5(string Model, int Mass, int Power):this()
        {
            WriteLine("+++ ctor params Engine5.");
            this.Model = Model;
            this.Power = Power;
            this.Mass = Mass;
            id = new Random().Next(1_000_000);
        }

        public string getInfo() {
            // Mass = 0; // !!!
            return $"Engine5 {Model}, Power: {Power}, Mass: {Mass}, Id: {id}.";
        }

        public override string ToString()
        {
            return getInfo();
        }

    }
    }

