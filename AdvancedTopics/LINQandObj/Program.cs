using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQandObj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User() { Name = "Gab", Mail = "gab@gmail.com" });
            users.Add(new User() { Name = "Joshua", Mail = "josh@hotmail.com" });
            users.Add(new User() { Name = "Chris", Mail = "chris@gmail.com" });
            users.Add(new User() { Name = "Joseph", Mail = "joseph@gmail.com" });
            users.Add(new User() { Name = "Thomas", Mail = "thommy@hotmail.com" });

            var queryList = users
                            .Where(item => item.Mail.Contains("@gmail.com"))
                            .OrderBy(item => item.Name.Length)
                            .Select(item => item);
            var count = 1;

            foreach (var item in queryList)
            {
                Console.WriteLine("#" + count + ": " + item.Name + " - " + item.Mail);

                count++;
            }

            Console.ReadKey();
        }
    }
}
