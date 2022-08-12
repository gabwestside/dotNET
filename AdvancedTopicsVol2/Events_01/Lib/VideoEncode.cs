 using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events_01.Lib
{
    public class VideoEncode
    {
        public delegate void VideoEncodedHandler(Video video);
        public event VideoEncodedHandler Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Converting video...");
            Thread.Sleep(2000);

            Console.WriteLine("Convert video!");

            Encoded(video);
        }
    }
}
