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

namespace ArcheageBot
{
    public partial class Form2 : Form
    {
        string aci;
        string lol1;
        string rtnStr;
        string EnStr;
        public bool bot = false;
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int keys);
        public Form2()
        {
            InitializeComponent();
        }
         
        private void Form2_Load(object sender, EventArgs e)
        {

           // DirectoryInfo papka = new DirectoryInfo(@"C:\Setting\" );
           // papka.Create();
           // FileInfo f = new FileInfo("setting.txt");
           // StreamWriter w = f.CreateText();
           // w.Close();
            
            label1.Text = "Проверка ключа";
            progressBar1.Value = 20;

            try
            {

                string drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\""); disk.Get();
                string diskLetter = (disk["VolumeSerialNumber"].ToString());
                lol1 = (Crypt(diskLetter.ToString()));
                
            }
            catch (Exception)
            {
                label1.Text = "Error";
            }
            string newCript = Crypt2(lol1);
            byte[] res = System.Text.Encoding.Default.GetBytes(newCript);
            aci = Encoding.ASCII.GetString(res);
            //string adv = Crypt2(aci);
            

            // string Black_SkypFile = "http://www.aabot.zyro.com/gallery/files/Version.txt";
           /// string Black_Skyp = null;
           // 
           // HttpWebRequest reques = (HttpWebRequest)WebRequest.Create(Black_SkypFile);// Веб запрос к нашему серверу
           // progressBar1.Value = 30;

///            HttpWebResponse respons = (HttpWebResponse)reques.GetResponse(); // Ответ сервера
//
//            StreamReader reade = new StreamReader(respons.GetResponseStream());// Используем чтение потока данных
//            Black_Skyp = reade.ReadLine();
//
 //           //String line;
 //          // StreamReader sr = new StreamReader(@"C:\ArcheAge\setting.txt");
 //          // line = sr.ReadLine();
 //           if ("1.3" == Black_Skyp)////////////////////////////////тут указывается текущая версия
 //           {
 //               FileInfo g = new FileInfo("Version.txt");
 //               StreamWriter h = g.CreateText();
 //               h.WriteLine("True");
 //               h.Close();
 //           }
 //           else
            //{
             //  FileInfo f = new FileInfo("Version.txt");
             //   StreamWriter w = f.CreateText();
             //   w.WriteLine("False");
             //   w.Close();
            //}
            
            

            //System.Threading.Thread.Sleep(8000);   
            string Black_SkypeFile = "http://www.aabot.zyro.com/gallery/files/Delete.txt";
            string Black_Skype = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Black_SkypeFile);// Веб запрос к нашему серверу
            progressBar1.Value = 30;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // Ответ сервера

            StreamReader reader = new StreamReader(response.GetResponseStream());// Используем чтение потока данных
            Black_Skype = reader.ReadLine();
            if (Black_Skype == "delete")
            {
                String dir = Environment.CurrentDirectory;
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                
                Directory.Delete(dir, true); //true - если директория не пуста (удалит и файлы и папки)
                Directory.CreateDirectory(dir);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            label1.Text = "Запуск ArcheAgeBot";
            timer1.Enabled = true;
        }

        private string Crypt(string text)
        {
             rtnStr = string.Empty;
            foreach (char c in text) // Цикл, которым мы и криптуем "текст" 
            {
                rtnStr += (char)((int)c + 1); //Число можно взять любое. 

            }
            return rtnStr; //Возвращаем уже закриптованную строку. 
        }
        private string Crypt2(string text)
        {
            rtnStr = string.Empty;
            foreach (char c in text) // Цикл, которым мы и криптуем "текст" 
            {
                rtnStr += (char)((int)c + 5); //Число можно взять любое. 

            }
            return rtnStr; //Возвращаем уже закриптованную строку. 
        }

        private string ENCrypt(string text)
        {
            string EnStr = string.Empty;
            foreach (char c in text) // Цикл, которым мы и криптуем "текст" 
            {
                EnStr += (char)((int)c - 1); //Число можно взять любое. 

            }
            return EnStr; //Возвращаем уже закриптованную строку. 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
            //////////////////////TRIAL/////////////////////////////////
            if (Hero.trial == true)
            {
                string Black_SkypeFile1 = "http://www.aabot.zyro.com/gallery/files/trial.txt";
                string Black_Skype1 = null;
               
                HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(Black_SkypeFile1);// Веб запрос к нашему серверу
               // progressBar1.Value = 30;

                HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse(); // Ответ сервера

                StreamReader reader1 = new StreamReader(response1.GetResponseStream());// Используем чтение потока данных
                Black_Skype1 = reader1.ReadLine();
                if (Black_Skype1 == "false")
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else
                {
                    timer1.Enabled = false;
                    label1.Text = "Приложение запущено";
                    progressBar1.Value = 100;
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
            }
            else
            {
                //////////////////////TRIAL/////////////////////////////////




                ////////////////////////////////////////////////// 
                /////////////////////FULL/////////////////////////  
                //////////////////////////////////////////////////

                bool KeyFound;
                KeyFound = false;
                int n;
                int k = 0;
                while (KeyFound == false)
                {
                    for (n = 1; n < 99999; n++)
                    {
                        
                        if (k < 100)
                        {
                            progressBar1.Value = k;
                        }
                        else { k = 0; }
                        k++;

                        try
                        {
                            //progressBar1.Value = n;
                            //string Black_SkypeFile = "http://www.aabot.zyro.com/gallery/files/Key1.txt";
                            string Black_SkypeFile = ("http://www.aabot.zyro.com/gallery/files/Keys/AgeKey" + n + ".txt");
                            string Black_Skype = null;
                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Black_SkypeFile);// Веб запрос к нашему серверу
                            
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // Ответ сервера
                            

                            StreamReader reader = new StreamReader(response.GetResponseStream());// Используем чтение потока данных
                            // loop2: ;
                            while (!reader.EndOfStream)
                            {
                                Black_Skype = reader.ReadLine();

                                

                                if (Crypt2(aci) == Black_Skype)
                                {
                                    KeyFound = true;
                                    timer1.Enabled = false;
                                    label1.Text = "Приложение запущено";
                                    progressBar1.Value = 100;
                                    Form1 form1 = new Form1();
                                    this.Hide();
                                    form1.ShowDialog();
                                    this.Show();
                                    timer1.Enabled = false;
                                    timer2.Enabled = false;
                                }
                            }
                        }
                        catch (Exception)
                        {
                           // MessageBox.Show(Exception.ex);
                        }
                        //else goto loop2;
                    }
                    ////////////////////////////////////////////////// 
                    /////////////////////FULL/////////////////////////  
                    //////////////////////////////////////////////////
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bot = true;
            timer1.Enabled = true;
        }
    }
}
