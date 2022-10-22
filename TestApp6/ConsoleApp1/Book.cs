using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        private string _id = "AA-2022-23-BBB";
        public string Id
        { 
          get { return _id; }
        }


    }
}
