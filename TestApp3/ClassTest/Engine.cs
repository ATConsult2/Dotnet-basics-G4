using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn.fact
{
    public class Engine
    {
        public string Model;
        public int Power;
        public int Mass;

        public Engine() {
            WriteLine("+++ ctor Engine.");
        }

        public string getInfo() {
            return $"Engine {Model}, Power: {Power}, Mass: {Mass}.";
        }

    }
}
