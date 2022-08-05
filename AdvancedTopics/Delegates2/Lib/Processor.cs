using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates2.Lib
{
    public static class Processor
    {
        public delegate void FilterHandler(Photo photo);

        public static FilterHandler filters;

        public static void Process(Photo photo)
        {
            filters(photo);
            /*
                var filters = new Filter();

                filters.Colorize(photo);
                filters.BlackAndWhite(photo);
                filters.GenerateThumb(photo);
                filters.Resize(photo);
            */
        }
    }
}
