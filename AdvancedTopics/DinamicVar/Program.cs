using System;

namespace DinamicVar
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "";
            object t = 123;
            t = "";

            var v1 = "";
            var v2 = 123;
            // var v3;
            // v2 = "";

            dynamic d1 = new User() { Name = "Gab" };

            Console.WriteLine(d1.Name);
            // Console.WriteLine(d1.Mail);

            d1 = "";

            Console.ReadKey();
        }

        class User
        {
            public string Name { get; set; }
        }
    }
}
