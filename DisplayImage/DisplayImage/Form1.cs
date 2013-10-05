using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            var pb1 = new PictureBox();
            pb1.ImageLocation = @"../../image.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(pb1);
        }
    }
}
