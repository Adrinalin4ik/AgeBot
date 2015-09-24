using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArcheageBot
{
    public partial class Form5 : Form
    {
        public static string pictureGuide;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (pictureGuide == "setting.jpg.deploy")
            {
                this.Size = new Size(610, 500);
                pictureBox1.Load(pictureGuide);
            }
            else
            {
                pictureBox1.Load(pictureGuide);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
