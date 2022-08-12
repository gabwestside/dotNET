using System;
using System.Collections.Generic;
using System.Text;

namespace Events_01.Lib.Mensenger
{
    public class Mail
    {
        public void SendMesage(Video video)
        {
            Console.WriteLine($"Mail send to {video.Name} video!");
        }
    }
}
