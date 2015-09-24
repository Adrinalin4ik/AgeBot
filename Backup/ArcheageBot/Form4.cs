using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace ArcheageBot
{
    public partial class Form4 : Form
    {
        int MXold, MYold;
        bool Windowmoving;
        public Form4()
        {
            InitializeComponent();
            Windowmoving = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            Windowmoving = true;

            MXold = e.X;
            MYold = e.Y;
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            Windowmoving = false;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (Windowmoving)
            {
                Point tmp = new Point(this.Location.X, this.Location.Y);


                tmp.X += e.X - MXold;
                tmp.Y += e.Y - MYold;

                this.Location = tmp;
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
    }
}
