using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library(new List<Book>());
            
            NewBookHandler S1 = text => WriteLine("S1: " + text);
            NewBookHandler S2 = text => WriteLine("S2: " + text);

            lib.NewBook += S1;
            lib.NewBook += S2;

            lib.AddBook(new Book() { Title = "Затеряннный Мир", Author = "Артур Конан-Дойл" });

            lib.NewBook -= S1;
            lib.AddBook(new Book() { Title = "Из пушки на Луну", Author = "Жюль Верн" });

        }
    }
}
