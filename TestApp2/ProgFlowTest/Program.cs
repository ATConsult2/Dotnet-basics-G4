
using static System.Console;


namespace andestech.learning2022.krasn
{

    //enum FileMode { 
    //Read=     0b1,
    //Write=   0b10,
    //Create= 0b100,
    //Append=0b1000,
    //}

    enum FileMode
    {
        Read =   1,
        Write =  2,
        Create = 4,
        Append = 8,
    }

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
                else {
                    checked { summa = a + b; } 
                }

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

        static void FileAccess(string fileName, FileMode fmode)
        { 
        
            switch(fmode)
            {
                case FileMode.Write:
                    WriteLine($"Write to {fileName}..");
                    break;
                case FileMode.Read:
                    WriteLine($"Read from {fileName}..");
                    break;
                case FileMode.Read | FileMode.Write:
                    WriteLine($"Read and Write from {fileName}..");
                    break;
                case FileMode.Create:
                    WriteLine($"Create file {fileName}..");
                    break;
                default:
                    WriteLine("some ops...");
                    break;

            }
        }

        static void LoopTest() {
                        
            for (int i = 1; i < 4; i++)
            {
                Write($"{i}, ");
            }
            WriteLine("\b\b.");

            // цикл на базе "бесконечного" цикла
            {
                int i = 1;
                for (;;)
                {
                    if (!(i < 4)) break;

                    Write($"{i}, ");
                    i++;    
                }
                WriteLine("\b\b.");
            }

            {
                int i = 1;
                while (i<4) {

                    Write($"{i}, ");
                    i++;
                }
                WriteLine("\b\b.");
            }

        }
        
        static void Main(string[] args)
        {
            //passTest();
            //SumOfInt();

            LoopTest();

            FileAccess("file1.txt", FileMode.Write | FileMode.Read);
            FileAccess("file1.txt", FileMode.Create);

            int amax = unchecked((1 << 31) - 1);

            WriteLine($"Min int -> {int.MinValue}");
            WriteLine($"Min int -> {(1<<31)}");
            WriteLine($"Max int -> {amax}");
            WriteLine($"Max int -> {int.MaxValue}");




            Write("Press any key...\n");
            ReadKey();
        }
    }
}
