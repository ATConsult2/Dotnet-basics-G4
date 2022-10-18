using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Pinta
    {
        public int I { get; private set; }
        private static Pinta[] _pintas = new Pinta[3];
        private Pinta(int i)
        { I = i; }
        public static Pinta getBeer(int i = 0)
        {
            if (i >= 0 && i < _pintas.Length)
            {
                if (_pintas[i] == null) _pintas[i] = new Pinta(i);
                return _pintas[i];
            }
            else return null;
        }
    }

}
