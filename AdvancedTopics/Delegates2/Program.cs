using Delegates2.Lib;
using System;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo { Name = "profile.jpg", WidthX = 1920, WidthY = 1080 };
            Processor.filters = new Filter().GenerateThumb;
            Processor.Process(photo);

            Photo photo2 = new Photo { Name = "product.jpg", WidthX = 1920, WidthY = 1080 };
            Processor.filters = new Filter().Colorize;
            Processor.filters += new Filter().Resize;
            Processor.Process(photo2);

            Photo photo3 = new Photo { Name = "album.jpg", WidthX = 1920, WidthY = 1080 };
            Processor.filters = new Filter().BlackAndWhite;
            Processor.Process(photo3);

            Console.ReadKey();
        }
    }
}
