using Library;
using Nancy.Json;
using System;
using System.IO;

namespace DeserializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\temp\files\serialize.json");
            string fileLines = streamReader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            User user = (User)serializer.DeserializeObject(fileLines);

            Console.WriteLine("User(Name): {0}, TaxNumber: {1} and Mail: {2}", user.Name, user.TaxNumber, user.Mail);
        }
    }
}
