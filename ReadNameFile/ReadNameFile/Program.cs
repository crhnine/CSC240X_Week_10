using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadNameFile
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream file = new FileStream(@"C:\Users\chris\OneDrive\Desktop\Week 10 Assignments\CreateNameFile\CreateNameFile\bin\Debug\Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            int count = 1;
            string name;

            Console.WriteLine("Displaying all names.");
            name = reader.ReadLine();
            while(name != null)
            {

                Console.WriteLine("" + count + " " + name);
                name = reader.ReadLine();
                ++count;


            }

            reader.Close();
            file.Close();

        }
    }
}
