using System;
using System.IO;
using Library;
using System.Xml.Serialization;

namespace SerializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Joseph Costas", TaxNumber = "111.222.333.44", Mail = "joseph@mail.com"};

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Gabriel\Documents\temp\files");

            serializer.Serialize(streamWriter, user);
        }
    }
}
