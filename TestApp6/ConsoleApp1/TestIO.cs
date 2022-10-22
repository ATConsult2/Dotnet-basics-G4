using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace andestech.learning2022.krasn
{
    internal class TestIO
    {
        static void Main(string[] args) {
            // TestReflection.Main2(args);
            FileInfo f1 = new FileInfo("file1.txt");
            if (f1.Exists) WriteLine("File exists!! Overwrite!!");
            f1.CopyTo($"file1_{DateTime.Now:yyyy_MM_dd_hh_mm_ss_fff}.txt", true);
            
             // Directory, DirectoryInfo

            File.WriteAllText(@"file1.txt", "Hi!\nHello!\nПривет", Encoding.UTF8);
            string[] lines =
                File.ReadAllLines("file1.txt", Encoding.UTF8);
            foreach(var line in lines) WriteLine(line);

            using (FileStream fs = new FileStream("file2.txt", FileMode.Append))
            {
                byte[] barr = Encoding.UTF8.GetBytes(
                    $"Created: {DateTime.Now:yyyy_MM_dd hh:mm:ss.fff}\n");
                fs.Write(barr, 0, barr.Length);
               //
               //fs.Seek(0, SeekOrigin.Begin);
            }

            using (BinaryWriter bw =
                new BinaryWriter(new FileStream("datas.bin", FileMode.OpenOrCreate)))
            {
                bw.Write(1.2345678912345);  //8
                bw.Write((byte)123);        //1 
                bw.Write(2022);             //4
            }
            using (BinaryReader br =
              new BinaryReader(new FileStream("datas.bin", FileMode.OpenOrCreate)))
            {
                WriteLine(br.ReadDouble());      //8
                WriteLine(br.ReadByte());        //1 
                WriteLine(br.ReadInt32());       //4
            }

            // StreamReader/ StreamWriter -  txt


                 }


    }
}
