using Library;
using Nancy.Json;
using System;
using System.IO;

namespace SerializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Kate Thomas", TaxNumber = "555.666.777-88", Mail = "kate@mail.com" };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string serializedObj = javaScriptSerializer.Serialize(user);

            StreamWriter streamWriter = new StreamWriter(@"C:\temp\files\serialize.json");
            streamWriter.WriteLine(serializedObj);
            streamWriter.Close();
        }
    }
}
