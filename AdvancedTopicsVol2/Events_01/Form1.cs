using Events_01.Lib;
using Events_01.Lib.Mensenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVideoEncode.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Video video = new Video() { Name = "Video.mp4" };

            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Mail().SendMesage;
            vid.Encoded += new SMS().SendMesage;

            vid.Encode(video);
        }
    }
}
