using System;
using System.IO;

namespace UsingFIleStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.moura.FITBANK\Documents\Gabs\tst.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (sr != null) fs.Close();
            }
        }
    }
}
