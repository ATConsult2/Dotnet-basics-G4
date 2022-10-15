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

        static int Summa(int multiplier, params int[] numbers) {
            int sum = 0;
            foreach (int number in numbers) sum += number;
            return sum*multiplier;
        }

        static int Summa(params byte[] numbers)
        {

            int sum = 0;
            foreach (int number in numbers) sum += number;
            return sum;
        }

        static void TrySwap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void PrintByteArray(byte[] arr)
        {
            Write("[");
            foreach (int number in arr) Write(number + ", ");
            Write("\b\b]\n");
        }

        static void Main(string[] args)
        {
            int a = 111, b = 222;
            WriteLine($"a={a}, b={b}.");
            TrySwap(a, b);
            WriteLine($"a={a}, b={b}.");
            WriteLine("-------------------");
            Swap(ref a, ref b);
            WriteLine($"a={a}, b={b}.");

            // ------ ARRAY TEST ---------
            byte[] arr1 = new byte[7];
            byte[] arr2 = new byte[] { 1, 88, 34, 254, 7 };

            arr1[3] = 111;

            Write("[");
            for (int i = 0; i < arr1.Length; i++)
            {
                Write(arr1[i] + ", ");
            }
            Write("\b\b]\n");

            PrintByteArray(arr2);

            // 1 Randome Byte Array
            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = (byte)rnd.Next(255);
            }
            PrintByteArray(arr1);
            // 2 Randome Byte Array
            rnd.NextBytes(arr1);
            PrintByteArray(arr1);
            WriteLine("-----------------------------");
            WriteLine(Summa(arr1));
            WriteLine(Summa(arr2));
            WriteLine(Summa(1,new int[] {1,2,3,4,5,6,7,8,9}));
            WriteLine(Summa(1, 2, 3, 4, 5, 6, 7, 8, 9));
            
            // Boxing & unboxing
            int data = 22;
            object o = data;
            o = 122.001;
            double data2 = (double)o;
            WriteLine(data + " --- " + data2);



        }
    }
}
