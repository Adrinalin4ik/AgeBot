using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Net;
using System.Management;
using System.Diagnostics;

namespace ArcheageBot
{
    public partial class Form3 : Form
    {
        
        int MXold, MYold;
        bool Windowmoving;
        public Form3()
        {
            InitializeComponent();
            Windowmoving = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Game.GetVersion("updater.xml","/ConfigurationFile/Version");
            label2.Text = Game.version;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com/agebot");
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            Windowmoving = true;
            
            MXold = e.X;
            MYold = e.Y;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            Windowmoving = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Windowmoving)
            {
                Point tmp = new Point(this.Location.X, this.Location.Y);
                
                
                tmp.X += e.X - MXold;
                tmp.Y += e.Y - MYold;
 
                this.Location=tmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }



        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            //////////////////////TRIAL/////////////////////////////////
                        string Black_SkypeFile1 = "http://www.aabot.zyro.com/files/trial.txt";
                        string Black_Skype1 = null;
            
                        HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(Black_SkypeFile1);// Веб запрос к нашему серверу
                       
            
                        HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse(); // Ответ сервера
            
                        StreamReader reader1 = new StreamReader(response1.GetResponseStream());// Используем чтение потока данных
                        Black_Skype1 = reader1.ReadLine();
                        if (Black_Skype1 == "false")
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                        else
                        {
                            TrialTimer.Enabled = false;
                            label1.Text = "Приложение запущено";
                            
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.ShowDialog();
                            this.Show();
                            TrialTimer.Enabled = false;
                            
                        }
            //////////////////////TRIAL/////////////////////////////////



        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://aabot.zyro.com/%D0%A2%D0%B5%D1%85-%D0%9F%D0%BE%D0%B4%D0%B4%D0%B5%D1%80%D0%B6%D0%BA%D0%B0/");
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (process.ProcessName == "archeage")
                {
                    listBox1.Items.Add(process.MainWindowTitle + " | " + process.MainWindowHandle);
                }
            }
            if (Program.ArcheageWindowTitle == null)
            {
                listBox1.Items.Add("Process is not running");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            int i = 0;
            foreach (Process process in processlist)
            {
                if (process.ProcessName == "archeage" && i==listBox1.SelectedIndex)
                {
                    i++;
                    Program.ArcheageWindowTitle = process.MainWindowTitle;
                    Program.ArcheageWindowHandle = process.MainWindowHandle;
                }
            }
            Program.Archeage = User32.FindWindow(null, Program.ArcheageWindowTitle);
            //MessageBox.Show(Convert.ToString(Program.Archeage));

            if (listBox1.SelectedItem == "Process is not running")
            {
                Process.GetCurrentProcess().Kill();
            }
            

            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();

        }

        

        
    }
}
