using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    class DataClass
    {
        public int Name { get; set; }
        public override string ToString()
        {
            return "DataClass:" + Name;
        }

    }

    struct DataStruct
    {
        public int Name { get; set; }
        public override string ToString()
        {
            return "DataStruct:" + Name;
        }

    }

}
