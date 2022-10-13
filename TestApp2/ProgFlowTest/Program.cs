
using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Program
    {

        static void SumOfInt()
        {
            int summa=0,a=0,b=0;
            while (true)
            {
                Write("Enter number1: "); string sa = ReadLine();
                Write("Enter number2: "); string sb = ReadLine();
                if (sa == "x" || sb == "x") 
                {
                    WriteLine("Thank you. Bye."); break; 
                }

                if (!int.TryParse(sa, out a) || !int.TryParse(sb, out b))
                {
                    WriteLine("Wrong number format.");
                    a = b = summa = 0;
                }
                else { summa = a + b; }

                WriteLine($"{a} + {b} = {summa}");


            } 
        
        }

        static int ReadInt() {
            int data = 0;
            Write("Enter int number: ");
            // data = int.Parse(ReadLine());
            string dataFromConsole = ReadLine();
            //data = int.Parse(dataFromConsole);

            if (!int.TryParse(dataFromConsole, out data))
            {
                WriteLine("Wrong input number.");
            }

            return data;
        }

        static void passTest() {
            Write("Pass1\n");
            Write("Pass2\tPass3\tPass3\n");
            int data = 0;

            while (true)
            {
                data = ReadInt();
                WriteLine($"data={data}");
            }


            WriteLine(string.Format("data={0}", data));
        }
        
        static void Main(string[] args)
        {
            //passTest();
            SumOfInt();

            Write("Press any key...\n");
            ReadKey();
        }
    }
}
