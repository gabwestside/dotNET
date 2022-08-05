using Delegates2.Lib;
using System;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo { Name = "photo.jpg", WidthX = 1920, WidthY = 1080 };

            Processor.Process(photo);

            Console.ReadKey();
        }
    }
}
