using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Basket
    {
        private Balloon[] Balloons { get; }

        public Basket(Balloon[] balloons)
        {
            Balloons = balloons;
        }

        public Basket(int size) {
            Balloons = new Balloon[size];
        }

        public Balloon this[int i]
        {
            get { return Balloons[i]; }
            set { Balloons[i] = value; }

        }

        public Balloon this[string s]
        {
            get
            {
                switch (s)
                {
                    case "one": return Balloons[0];
                    case "two": return Balloons[1];
                    case "three": return Balloons[2];
                    default: return null;
                }
            }
        }

        // Add, Remove, Get

    }
}
