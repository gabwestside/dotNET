using Library;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DeserializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\temp\files\serialize.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(User));

            User user = (User) serializer.Deserialize(streamReader);

            Console.WriteLine("User(Name): {0}, TaxNumber: {1} and Mail: {2}", user.Name, user.TaxNumber, user.Mail);
            Console.ReadKey();
        }
    }
}
