using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    [Serializable]
    class SereClass
    {
        String Name;
        int age;
        public SereClass(String Sname, int Sage)
        {
            Name = Sname;
            age = Sage;
        }

        public void Sere()
        {
            SereClass sclass = new SereClass("sakthi", 21);
            FileStream fs = new FileStream("SereData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sclass);
            fs.Close();
        }
        public static void Main()
        {
            
            FileStream fs = new FileStream("SereData.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            SereClass sc = (SereClass)bf.Deserialize(fs);
            Console.WriteLine(sc.Name);
            Console.WriteLine(sc.age);
            fs.Close();
        }

    }
}