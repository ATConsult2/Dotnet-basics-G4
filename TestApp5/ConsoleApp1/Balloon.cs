using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Balloon : IComparable<Balloon>
    {
        public double R { get; private set; }
        private const double DELTA7 = 0.0000001;

        public Balloon() { }
        public Balloon(double r)
        {
            R = r;
        }

        public static Balloon operator +(Balloon b1, Balloon b2) {
           double v1 = b1.R * b1.R * b1.R;
           double v2 = b2.R * b2.R * b2.R;

           double Rnew = Math.Pow(v1 + v2, 1.0 / 3.0);
           return new Balloon(r: Rnew);

        }

        public static bool operator ==(Balloon b1, Balloon b2)
        {
            if (Math.Abs(b1.R - b2.R) < DELTA7) return true;
            else return false;
        }

        public static bool operator !=(Balloon b1, Balloon b2)
        {
            if (Math.Abs(b1.R - b2.R) >= DELTA7) return true;
            else return false;
        }

        public static Balloon operator ++(Balloon b1) // +0.5*3/4/Pi
        {
            double v1 = b1.R * b1.R * b1.R;
            double Rnew = Math.Pow(v1 + 0.5, 1.0 / 3.0);
            return new Balloon(r: Rnew);
        }

        public static Balloon Add(Balloon b1, Balloon b2)
        {
            double v1 = b1.R * b1.R * b1.R;
            double v2 = b2.R * b2.R * b2.R;

            double Rnew = Math.Pow(v1 + v2, 1.0 / 3.0);
            return new Balloon(r: Rnew);

        }

        public override string ToString()
        {
            return $"Ballon: {R:##.####}, id: {GetHashCode()}";
            
        }

        public int CompareTo(Balloon other)
        {
            return (int)(R - other.R);
        }
    }
}
