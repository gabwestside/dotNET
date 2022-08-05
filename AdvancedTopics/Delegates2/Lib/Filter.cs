using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates2.Lib
{
    public class Filter
    {
        public void Colorize(Photo photo)
        {
            Console.WriteLine($"Filter > Colorize: {photo.Name}");
        }

        public void GenerateThumb(Photo photo)
        {
            Console.WriteLine($"Filter > GenerateThumb: {photo.Name}");
        }

        public void BlackAndWhite(Photo photo)
        {
            Console.WriteLine($"Filter > BlackAndWhite: {photo.Name}");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine($"Filter > Resize: {photo.Name}");
        }
    }
}
