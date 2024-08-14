using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
    internal class readFromFile // Class will read vehicle information from a file and print in the console
    {
        private string filePath;

        public readFromFile(string path)
/*
            string[] lines = File.ReadAllLines(textFile);
            foreach (string line in lines)
            Console.WriteLine(line);*/

        {
            try
            {
                File.Exists(path);
            }
            catch (IOException e)
            {

                Console.WriteLine("Unable to read file, Please check the path and try again");
                Console.WriteLine(e.Message);

            }
            filePath = path;
        }

        public readFromFile()
        {
            this.filePath = string.Empty;
        }

        public void setPath(string path)
        {
            this.filePath = path;
        }

        public String getText()
        {
            string returnStr = string.Empty;
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
                returnStr += line;

            return returnStr;
        }
    }
}
