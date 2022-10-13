
using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Program
    {

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
        
        static void Main(string[] args)
        {
            Write("Pass1\n");
            Write("Pass2\tPass3\tPass3\n");
            int data = 0;

            while (true)
            {
                data = ReadInt();
                WriteLine($"data={data}");
            }


            WriteLine(string.Format("data={0}", data));


            Write("Press any key...\n");
            ReadKey();
        }
    }
}
