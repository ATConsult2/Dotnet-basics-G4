using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class LogLevelAttribute : Attribute
    {
        private int _level = 7;
        public LogLevelAttribute() { }
        public LogLevelAttribute(int level )
        {
            _level = level;
        }
        public int Level { get => _level; }
    }
}
