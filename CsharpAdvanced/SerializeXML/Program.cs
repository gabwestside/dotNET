using Library;
using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "Joseph Costas", TaxNumber = "111.222.333.44", Mail = "joseph@mail.com" };

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            StreamWriter streamWriter = new StreamWriter(@"C:\temp\files\serialize.xml");

            serializer.Serialize(streamWriter, user);
        }
    }
}
