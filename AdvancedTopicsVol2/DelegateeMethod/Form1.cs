using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateeMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnClick.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Hi, I was clicked!");
            };
        }

        //private void btnClick_Click(object sender, EventArgs e)
        //{

        //}
    }
}
