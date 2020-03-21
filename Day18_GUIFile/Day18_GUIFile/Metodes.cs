using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day18_GUIFile
{
    class Metodes
    {
        public static void ReadFile(List<String> list)
        {
            try
            {
                StreamReader read = new StreamReader("C:\\Users\\ronis\\OneDrive\\Documents\\Task1.txt");
                String rinda = read.ReadLine();
                list.Add(rinda);

                while (!read.EndOfStream)
                {
                    rinda = read.ReadLine();
                    list.Add(rinda);
                }
                read.Close();
            }
            catch
            {

            }
        }
    }
}
