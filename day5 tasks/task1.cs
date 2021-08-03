using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class d5task1
    {
        public void WriteFyle()
        {
            FileStream fs = new FileStream("c:\\c#\\day5 tasks\\testcase1.cs", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            Console.WriteLine("the deserts are");
            ArrayList al = new ArrayList();
            al.Add("ice cream");
            al.Add("cake");
            al.Add("pudding");
            foreach (var i in al)
            {
                sw.WriteLine(i);


            }
            Console.ReadLine();
           // FileStream fs = new FileStream("c:\\c#\\day5 tasks\\task1.cs", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            //sw.Write();
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public void ReadFyle()
        {
            FileStream fs = new FileStream("c:\\c#\\day5 tasks\\testcase1.cs", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(
                sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        public void FyleDetail()
        {
            FileInfo f1 = new FileInfo("c:\\c#\\day5 tasks\\testcase1.cs");

            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.CreationTime);



        }
        public static void Main()
        {
            d5task1 fobj = new d5task1();
            fobj.WriteFyle();
            fobj.ReadFyle();
            fobj.FyleDetail();
            Console.Read();

        }
    }
}

