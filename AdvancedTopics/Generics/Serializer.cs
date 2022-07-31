using Nancy.Json;
using System.IO;

namespace Generics
{
    public class Serializer
    {
        public static void Serialize(object obj)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\temp\files\" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string serializeObj = serializer.Serialize(obj);

            streamWriter.WriteLine(serializeObj);
            streamWriter.Close();
        }

        public static T Deserialize<T>()
        {
            StreamReader streamReader = new StreamReader(@"C:\temp\files\" + typeof(T).Name + ".txt");

            string fileContent = streamReader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            T obj = (T) serializer.Deserialize<T>(fileContent);

            return obj;
        }
    }
}
