#define RELEASE_A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection;
using System.Diagnostics;

namespace andestech.learning2022.krasn
{
    internal class TestReflection
    {
        public static void Main2(string[] args)
        {

            Type type = typeof(Book);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Console.WriteLine(prop.Name + " ---- " + prop.Module);
            }

            Book b = new Book() { Title = "Затеряннный Мир", Author = "Артур Конан-Дойл" };

            FieldInfo fi = type.GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            WriteLine(b.Id);
            fi?.SetValue(b,"AAA-2023333-111");
            WriteLine(b.Id);

            FA();
            FB();
            //---------------
            WriteLine("----------- LIB Attribute test ----------");
            Type typeLib = typeof(Library);
            LogLevelAttribute attr =
                typeLib.GetCustomAttribute(typeof(LogLevelAttribute), false)
                as LogLevelAttribute;
            WriteLine("Log Level: " + attr.Level);


        }
        [Conditional("RELEASE_A")]
        static void FA() => WriteLine("FA!");

        [Conditional("RELEASE_B")]
        static void FB() { WriteLine("FB!"); }
    }
}
