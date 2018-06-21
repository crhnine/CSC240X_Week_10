﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace AccessSomeNames
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream file = new FileStream(@"C:\Users\chris\OneDrive\Desktop\Week 10 Assignments\CreateNameFile\CreateNameFile\bin\Debug\Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            const int END = 999;
            int count = 0;
            int num;
            int size;
            string name;

            name = reader.ReadLine();
            while(name != null)
            {

                ++count;
                name = reader.ReadLine();

            }
            size = (int)file.Length / count;
            Write("\nWith which number do you want to start? >> ");
            num = Convert.ToInt32(ReadLine());

            while(num != END)
            {

                WriteLine("Starting with name " + num + ":  ");
                file.Seek((num - 1) * size, SeekOrigin.Begin);

                name = reader.ReadLine();
                WriteLine(" " + name);
                while(name != null)
                {
                    name = reader.ReadLine();
                    WriteLine(" " + name);

                }

                WriteLine("\nWith which number do you " +
                    "want to start?");
                Write("   (Enter " + END + " to quit.) >> ");
                num = Convert.ToInt32(ReadLine());


            }

            reader.Close();
            file.Close();

        }
    }
}
