using Generics.Model;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Brand = "FIAT", Model = "Uno" };
            House house = new House() { Address = "Av. Santos Dumont", City = "Fortaleza" };
            User user = new User() { Name = "Gab", Mail = "gab@mail.com", Password = "101912" };

            Serializer.Serialize(car);
            Serializer.Serialize(house);
            Serializer.Serialize(user);

            Car carTwo = Serializer.Deserialize<Car>();
            House houseTwo = Serializer.Deserialize<House>();
            User userTwo = Serializer.Deserialize<User>();

            Console.WriteLine("2nd Car: " + carTwo.Brand + " - " + carTwo.Model);
            Console.WriteLine("2nd House: " + houseTwo.City + " - " + houseTwo.Address);
            Console.WriteLine("2nd User " + userTwo.Name + " - " + userTwo.Mail);

            Console.ReadKey();

        }
    }
}
