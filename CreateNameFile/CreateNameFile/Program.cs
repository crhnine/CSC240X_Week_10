﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateNameFile
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream file = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            string[] names =
            {
                "Anthony   ",
                "Belle     ",
                "Carolyn   ",
                "David     ",
                "Edwin     ",
                "Frannie   ",
                "Gina      ",
                "Hannah    ",
                "Inez      ",
                "Juan      "
            };

            int x;
            for (x = 0; x < names.Length; x++)
            {

                writer.WriteLine(names[x]);




            }

            writer.Close();
            file.Close();


        }
    }
}
