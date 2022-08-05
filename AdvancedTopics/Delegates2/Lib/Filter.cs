using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates2.Lib
{
    public class Filter
    {
        public void Colorize(Photo photo)
        {
            Console.WriteLine("Filter > Colorize");
        }

        public void GenerateThumb(Photo photo)
        {
            Console.WriteLine("Filter > GenerateThumb");
        }

        public void BlackAndWhite(Photo photo)
        {
            Console.WriteLine("Filter > BlackAndWhite");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Filter > Resize");
        }
    }
}
