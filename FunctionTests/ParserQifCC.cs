using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    class ParserQifCC
    {
        public static void Parse(string filename)
        {
            StreamReader reader = File.OpenText(filename);

            string line;
            string text = "";
            while ((line = reader.ReadLine()) != null)
            {
                if(line.IndexOf("D") == 0)
                {
                    line = line.Remove(6, 3).Insert(6, "'");
                }
                text += "\r\n" + line;
            }

            reader.Close();

            File.WriteAllText(filename, text);

            reader = File.OpenText(filename);
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("--> "+ line);
            }

        }

        public static void DateCorrection(string line, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine(line);
           

        }
    }
}
