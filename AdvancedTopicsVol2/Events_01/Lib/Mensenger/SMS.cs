using System;
using System.Collections.Generic;
using System.Text;

namespace Events_01.Lib.Mensenger
{
    public class SMS
    {
        public void SendMesage(Video video)
        {
            Console.WriteLine($"SMS send to {video.Name} video!");
        }
    }
}
