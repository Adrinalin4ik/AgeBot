using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Management;
using System.Diagnostics;
namespace ArcheageBot
{
    
    public partial class Form1 : Form
    {
        #region Varieties
        bool PlaceFarmDeath,PlaceMobFarm;
        int xhero, yhero;
        bool herosetting;
        int MXold, MYold;
        bool Windowmoving;
        int record;
        int loot;
        bool shutdownlistbox;
        int currenttime5;
        int CoordinX;
        int CoordinY;
        bool deadtik;
        int dead;
        bool death;
        bool baflist1;
        bool baflist2;
        bool baflist3;
        int CurrentTime4;
        bool timecheck1;
        bool mobsetting;
        int CurrentTime1;
        int CurrentTime2;
        int CurrentTime3;
        int Time;
        bool zasadkaend = false;
        int k = 0;   
        bool batcheck2=true;
        bool batcheck;
        int mobchecker;
        bool puck = false;
        bool gather = false;
        bool mob;
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int keys);
        [DllImport("user32.dll")]
        public static extern int SendMessageA(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        #endregion Varieties
        public Form1()
        {
            readHeroSetting();
            InitializeComponent();
            Windowmoving = false;
           // herosetting = false;
            PlaceFarmDeath = false;
            PlaceMobFarm = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Hero.trial == true)
            {
                label57.Visible = true;
                label57.Text = "TRIAL VERSION";

            }
            else label57.Visible = false;

            shutdownlistbox = true;
            CoordinX = GrindBot.ToCoordX;
            CoordinY = GrindBot.ToCoordY;
            if (ShutdowdCheck.Checked == true)
            {
                timecheck1 = true;
            }
            bool stringchecker = true; ;
            bool podstroyka = false;
            bool vtorayaproverka = true;

            StreamReader sr = new StreamReader("Setting.txt");
            while (sr.Peek() != -1)
            {
                string Line = sr.ReadLine();      // Line = sr.ReadToEnd();
                if (Convert.ToDouble(Line) > 0)
                {
                    if (stringchecker == true)
                    {
                        Hero.ihp = Convert.ToInt32(Line);
                        stringchecker = false;
                    }
                    else
                        if (vtorayaproverka == true)
                        {
                            Hero.jhp = Convert.ToInt32(Line);
                            podstroyka = true;
                            vtorayaproverka = false;
                            goto loop;
                        }
                    if (podstroyka == true)
                    {
                        numericUpDown9.Value = Convert.ToInt32(Line);
                    }
                //MessageBox.Show(Line);
                loop: ;
                }
            }
            sr.Close();    // sr.Dispose();
            if ((Hero.ihp > 0) && (Hero.jhp > 0))
            {
                mobsetting = true;
            }


            listBox1.Items.Add("Age Bot");
            listBox1.Items.Add("Current version >> " + Game.version);
            listBox1.Items.Add(">> Официальная группа: vk.com/agebot <<");
            listBox1.Items.Add(">> Пользуясь ботом , вы нарушаете правила игры << ");
            listBox1.Items.Add(">> Администрация не несет ответственности за ваш аккаунт << ");
            BufCheck1.Checked = false;
            BufCheck2.Checked = false;
            BufCheck3.Checked = false;
            Time = 0;
            checkBox2.Checked = false;
            numericUpDown2.Value = 170;
            numericUpDown3.Value = 170;
            textBox6.Text = "200";
            button22.Visible = false;
            button11.Visible = false;
            button16.Visible = false;
            button15.Visible = false;
            button14.Visible = false;
            button8.Visible = false;
            toolTip1.SetToolTip(button1, "Движение по записанному маршруту (мобов не трогает)");
            toolTip1.SetToolTip(numericUpDown1, "интервал записи ( в пикселях)");
            //HeroTimer.Enabled = true;
            // GameTimer.Enabled = true;
            // InterfaceTimer.Enabled = true;
            // ViewDirectionTimer.Enabled = true;

            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new System.Drawing.Point(width - this.Size.Width, height - this.Size.Height);

        }

        private void ScreenCaptureTimer_Tick(object sender, EventArgs e)
        {

            ScreenCapture CurrentScreen = new ScreenCapture();
            ScreenCapture.Screen = CurrentScreen.CaptureScreen();
            pictureBox1.Image = ScreenCapture.Screen;

            ScreenCapture.LockBitmap.Screen = new ScreenCapture.LockBitmap(new Bitmap(ScreenCapture.Screen));
            ScreenCapture.LockBitmap.Screen.LockBits();
            //ScreenCapture.LockBitmap.Screen.UnlockBits(); - не известно назначение, работает и без неё
        }

        private void ViewDirectionTimer_Tick(object sender, EventArgs e)
        {
            bool FastFind1 = false;
            bool FastFind2 = false;
            bool FastFind3 = false;

            /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
            if (
                ((Hero.PositionX - 5 > 0) && (Hero.PositionY - 5 > 0)) &&
                ((Hero.PositionX + 5 < ScreenCapture.LockBitmap.Screen.Width) && (Hero.PositionY + 5 < ScreenCapture.LockBitmap.Screen.Height))

            )
            {
                bool FindForm = false;
                for (int y = Hero.PositionY - 5; y < Hero.PositionY + 5; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = Hero.PositionX - 5; x < Hero.PositionX + 5; x++)
                    {
                        if (FindForm == true) { break; }

                        int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                        if (HeroCircleForm != null)
                        {
                            FastFind1 = true;
                            FindForm = true;
                            int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                            Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                            Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                            Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                        }
                    }
                }
            }


            if (FastFind1 == false)
            {
                /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
                if (
                    ((Hero.PositionX - 10 > 0) && (Hero.PositionY - 10 > 0)) &&
                    ((Hero.PositionX + 10 < ScreenCapture.LockBitmap.Screen.Width-10) && (Hero.PositionY + 10 < ScreenCapture.LockBitmap.Screen.Height-10))

                )
                {
                    bool FindForm = false;
                    for (int y = Hero.PositionY - 10; y < Hero.PositionY + 10; y++)
                    {
                        if (FindForm == true) { break; }
                        for (int x = Hero.PositionX - 10; x < Hero.PositionX + 10; x++)
                        {
                            if (FindForm == true) { break; }

                            int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                            if (HeroCircleForm != null)
                            {
                                FastFind2 = true;
                                FindForm = true;
                                int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                                Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                                Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                                Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                            }
                        }
                    }
                }
            }

            if ((FastFind1 == false) && (FastFind2 == false))
            {
                /* Для начала попробуем найти кружочек примерно рядом с последними координатами */
                if (
                    ((Hero.PositionX - 20 > 0) && (Hero.PositionY - 20 > 0)) &&
                    ((Hero.PositionX + 20 < ScreenCapture.LockBitmap.Screen.Width-10) && (Hero.PositionY + 20 < ScreenCapture.LockBitmap.Screen.Height-10))

                )
                {
                    bool FindForm = false;
                    for (int y = Hero.PositionY - 20; y < Hero.PositionY + 20; y++)
                    {
                        if (FindForm == true) { break; }
                        for (int x = Hero.PositionX - 20; x < Hero.PositionX + 20; x++)
                        {
                            if (FindForm == true) { break; }

                            int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                            if (HeroCircleForm != null)
                            {
                                FastFind3 = true;
                                FindForm = true;
                                int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                                Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                                Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                                Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                            }
                        }
                    }
                }
            }

            /* Если не получилось быстро найти кружочек - ищем по всей карте */
            if ((FastFind1 == false) && (FastFind2 == false) && (FastFind3 == false))
            {
                bool FindForm = false;
                for (int y = 50; y < ScreenCapture.LockBitmap.Screen.Height - 10; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = 600; x < ScreenCapture.LockBitmap.Screen.Width - 50; x++)
                    {
                        if (FindForm == true) { break; }

                        int? HeroCircleForm = VisionForm.FindForm(VisionHeroLocation.HeroCircles, x, y);
                        if (HeroCircleForm != null)
                        {
                            FindForm = true;
                            int HeroCircleFormNumber = HeroCircleForm ?? default(int);
                            Hero.PositionX = x + VisionHeroLocation.HeroCirclesOffsetsX[HeroCircleFormNumber];
                            Hero.PositionY = y + VisionHeroLocation.HeroCirclesOffsetsY[HeroCircleFormNumber];
                            Hero.Direction = VisionHeroLocation.GetCurrentDirection(HeroCircleFormNumber, x, y);
                        }
                    }
                }
            }
        }

        private void TargetTimer_Tick( object sender, EventArgs e)
        {

            if (Hero.Health < Hero.healhp)
            {
                Hero.Target = true;
            }

           //     Color CurrentColor;
           //     CurrentColor = ScreenCapture.LockBitmap.Screen.GetPixel(xs, ys);
           
                        

                  //      C = ScreenCapture.LockBitmap.Screen.GetPixel(xs, ys);


       
//
 //                       /* Определяем количество ХП у врага */
 //                       int EnemyHpLenght;
 //                       for (EnemyHpLenght = 0; EnemyHpLenght < 365; ++EnemyHpLenght)
 //                       {
 //                           if (VisionForm.FindForm(VisionEnemy.EnemyBars, x + EnemyHpLenght + 1, y + 2) != null)
 //                           {
 //                               //continue;
 //                           }
 //                           else
 //                           {
 //                               break;
 //                           }
                       


                            /* Определяем дистанцию для разных типов монстров */
                           
//
//                            Enemy.Health = EnemyHpLenght;
//                        }
                    
//                }
//            }
//
//            if (FindForm == false)
//            {
//                Hero.Target = false;
//                Enemy.Distance = null;
//                Enemy.Health = null;
//            }
//
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = Hero.PositionX.ToString();
            label3.Text = Hero.PositionY.ToString();
            label7.Text = Enemy.Distance.ToString();
            label6.Text = Enemy.Health.ToString();
            label8.Text = Enemy.OnScreen.ToString();
            label9.Text = Hero.Direction;
            label10.Text = Enemy.OnScreenPosition;
            label11.Text = Hero.Health.ToString();
            label12.Text = Hero.Mana.ToString();
            label13.Text = Hero.Target.ToString();
            label14.Text = Game.ButtonG.ToString();
            label16.Text = Hero.NoUpdateDirectionIteration.ToString();
            label18.Text = GrindBot.ToCoordX.ToString();
            label19.Text = GrindBot.ToCoordY.ToString();
            label17.Text = GrindBot.Direction;
            label20.Text = GrindBot.SleepRun.ToString();
            //listBox1.Items = GrindBot.getkey;
           
            
                label35.Text = Game.ButtonF.ToString();

            
            //if ((gather == true) && (Game.ButtonF == true))
            //{
                
             //       Hero.Action = "Working";
             //       System.Threading.Thread.Sleep(500);
                  
               
            //}
           
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            bool FindForm = false;

            if (Hero.Target == true)
            {
                int SearchRangeX;
                if (Enemy.GlobalSearchOnScreen == true)
                {
                    SearchRangeX = 10;
                    Enemy.GlobalSearchOnScreen = false;
                }
                else
                {
                    SearchRangeX = 430;
                }

                for (int y = 10; y < ScreenCapture.LockBitmap.Screen.Height - 300; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = SearchRangeX; x < ScreenCapture.LockBitmap.Screen.Width - SearchRangeX; x++)
                    {
                        if (FindForm == true) { break; }
                        if (VisionForm.FindForm(VisionEnemy.EnemyTooltips, x, y) != null)
                        {
                            FindForm = true;
                            Enemy.OnScreen = true;

                            /* Определяем с какой границы экрана у нас полоска ХП */

                            int FindScreenLenght = ScreenCapture.LockBitmap.Screen.Width - SearchRangeX - SearchRangeX;

                            if (x < (SearchRangeX + (FindScreenLenght / 2)))
                            {
                                Enemy.OnScreenPosition = "Left";
                            }
                            else
                            {
                                Enemy.OnScreenPosition = "Right";
                            }

                        }
                    }
                }
            }
            else
            {
                Enemy.GlobalSearchOnScreen = true;
            }

            if (FindForm == false)
            {
               // Enemy.OnScreen = false;
            }
        }
       
        

        const int DISTANCE = 10;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0046 /* WM_WINDOWPOSCHANGING */)
            {
                Rectangle workArea = SystemInformation.WorkingArea;
                Rectangle rect = (Rectangle)Marshal.PtrToStructure((IntPtr)(IntPtr.Size * 2 + m.LParam.ToInt64()), typeof(Rectangle));

                if (rect.X <= workArea.Left + DISTANCE)
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2, workArea.Left);

                if (rect.X + rect.Width >= workArea.Width - DISTANCE)
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2, workArea.Right - rect.Width);

                if (rect.Y <= workArea.Top + DISTANCE)
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2 + 4, workArea.Top);

                if (rect.Y + rect.Height >= workArea.Height - DISTANCE)
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2 + 4, workArea.Bottom - rect.Height);
            }

            base.WndProc(ref m);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Hero.xywalking = checkBox3.Checked;
            puck = true;
            Route.LoadGrindRoute("RecordPackA=BRoute.txt");
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            Hero.Action = "RunOnLocation";
            timer2.Enabled = true;
            EnemyHealthBar.Enabled = true;
            button1.Visible = false;
            button16.Visible = true;
            button20.Visible = false;
            pak.Enabled = true;

        }

        private void HeroTimer_Tick(object sender, EventArgs e)
        {
            if (herosetting == false)
            {
                bool FindForm = false;

                for (int y = 10; y < 768; y++)
                {
                    if (FindForm == true) { break; }
                    for (int x = 0; x < 1024; x++)
                    {
                        if (FindForm == true) { break; }

                        if (VisionForm.FindForm(VisionHero.HeroBars, x, y) != null)
                        {
                             xhero = x;
                             yhero = y;
                            FindForm = true;
                            herosetting = true;

                            /* Определяем количество ХП у героя */
                            int HeroHpLenght;
                            for (HeroHpLenght = 0; HeroHpLenght < 255; ++HeroHpLenght)
                            {
                                if (VisionForm.FindForm(VisionAlliance.AllianceBars, x + HeroHpLenght + 1, y + 2) != null)
                                {
                                    //continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            Hero.Health = HeroHpLenght;
                            progressBar1.Value = HeroHpLenght;

                            if (Hero.Health < Hero.healhp)
                            {
                                if (Hero.Health == 0)
                                {
                                    Hero.Target = false;
                                    Enemy.OnScreen = false;
                                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                                    //System.Threading.Thread.Sleep(3000);
                                }
                                Hero.Target = true;
                                Enemy.OnScreen = true;
                                // System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                // Hero.Target = false;
                                // Enemy.OnScreen = false;
                            }
                            /* Определяем количество МП у героя */
                            int HeroManaLenght;
                            for (HeroManaLenght = 0; HeroManaLenght < 255; ++HeroManaLenght)
                            {
                                if (VisionForm.FindForm(VisionAlliance.ManaBars, x + HeroManaLenght + 1, y + 19) != null)
                                {
                                    //continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            Hero.Mana = HeroManaLenght;
                            progressBar2.Value = HeroManaLenght;
                            if (Hero.Mana < Hero.healmp)
                            {
                                if (Hero.Mana == 0)
                                {
                                    Hero.Target = false;
                                    Enemy.OnScreen = false;
                                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                                    // System.Threading.Thread.Sleep(3000);

                                }
                                Hero.Target = true;
                                Enemy.OnScreen = true;
                                //System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                //Hero.Target = false;
                                // Enemy.OnScreen = false;
                            }
                        }
                    }
                }

                if (FindForm == false)
                {
                    Hero.Health = null;
                    Hero.Mana = null;
                }
            }
            else
            {
                int HeroHpLenght;
                for (HeroHpLenght = 0; HeroHpLenght < 255; ++HeroHpLenght)
                {
                    if (VisionForm.FindForm(VisionAlliance.AllianceBars, xhero + HeroHpLenght + 1, yhero + 2) != null)
                    {
                        //continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Hero.Health = HeroHpLenght;
                progressBar1.Value = HeroHpLenght;

                if (Hero.Health < Hero.healhp)
                {
                    if (Hero.Health == 0)
                    {
                        Hero.Target = false;
                        Enemy.OnScreen = false;
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                    }
                    Hero.Target = true;
                    Enemy.OnScreen = true;
                }

                /* Определяем количество МП у героя */
                int HeroManaLenght;
                for (HeroManaLenght = 0; HeroManaLenght < 255; ++HeroManaLenght)
                {
                    if (VisionForm.FindForm(VisionAlliance.ManaBars, xhero + HeroManaLenght + 1, yhero + 19) != null)
                    {
                        //continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Hero.Mana = HeroManaLenght;
                progressBar2.Value = HeroManaLenght;
                if (Hero.Mana < Hero.healmp)
                {
                    if (Hero.Mana == 0)
                    {
                        Hero.Target = false;
                        Enemy.OnScreen = false;
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                    }
                    Hero.Target = true;
                    Enemy.OnScreen = true;
                  
                }
               
               
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            Game.FindActionButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            Program.testint = Program.testint + 1;
            label15.Text = Hero.Action;

            if (Program.NextAction == true)
            {
                Program.testint = 0;
                if (Hero.Action == "RunOnLocation")
                {
                    Program.NextAction = false;
                    Program.RunOnLocation = new Thread(new ThreadStart(GrindBot.RunOnLocation));
                    Program.RunOnLocation.Start();
                }
                else if (Hero.Action == "Fight")
                {
                    Program.NextAction = false;
                    Program.Fight = new Thread(new ThreadStart(GrindBot.Fight));
                    Program.Fight.Start();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secundomer.Enabled = true;
            DeathTimer.Enabled = true;
            deadtik = true;
            if (checkBox2.Checked == true)
            {
                SquareTimer.Enabled = true;
            }
            else
            {
                if ((BufCheck1.Checked == true) || (BufCheck2.Checked == true) || (BufCheck2.Checked == true))
                {
                    StartBuf.Enabled = true;
                }
           Secundomer.Enabled = true;
           BufTimer.Enabled = true;
           
           Time = 0;    
           CurrentTime1 = 0;
           CurrentTime2 = 0;
           CurrentTime3 = 0;
            Hero.xywalking = checkBox1.Checked;
            Hero.healhp = (int)numericUpDown2.Value;
            Hero.healmp = (int)numericUpDown3.Value;
            Route.LoadGrindRoute("RecordRoute.txt");
            FailedLoot.Enabled = true;
            //LootTimer.Enabled = true;
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            Hero.Action = "RunOnLocation";
            timer2.Enabled = true;

            if (mobsetting == true)
            {
                EnemyHealthBar.Enabled = false;
                mainmobhp.Enabled = true;
            }
            else
            {
                EnemyHealthBar.Enabled = true ;
            }
           
            button3.Visible = false;
            button8.Visible = true;
            }
            
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Hero.Action = "Stop";
            listBox1.Items.Add(">> Мобов нафармлено:" + mobchecker + " <<");
            listBox1.Items.Add(">> Количество смертей: " + dead + " <<");
            listBox1.Items.Add(">> Бот был выключен в " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " <<");
            TextWriter writer = new StreamWriter("log.txt");
            foreach (var item in listBox1.Items)
                writer.WriteLine(item.ToString());
            writer.Close();
            
          
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            record=Convert.ToInt32(numericUpDown1.Value);
            ViewDirectionTimer.Enabled = true;          
            InterfaceTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            RouteRecordTimer.Enabled = true;
            //timer2.Enabled = true;
        }

        private void RouteRecordTimer_Tick(object sender, EventArgs e)
        {
            
           // if ((Math.Abs(Hero.PositionX - RouteRecord.LastRecordCoordX) > Convert.ToInt32(textBox3.Text)) || (Math.Abs(Hero.PositionY - RouteRecord.LastRecordCoordY) > Convert.ToInt32(textBox3.Text)))
            if ((Math.Abs(Hero.PositionX - RouteRecord.LastRecordCoordX) > record) || (Math.Abs(Hero.PositionY - RouteRecord.LastRecordCoordY) > record))

            //if ((Math.Abs(Hero.PositionX - RouteRecord.LastRecordCoordX) > 1) || (Math.Abs(Hero.PositionY - RouteRecord.LastRecordCoordY) > 1))
            {
                RouteRecord.LastRecordCoordX = Hero.PositionX;
                RouteRecord.LastRecordCoordY = Hero.PositionY;

                RouteRecord.GrindRoutes.Add(new Route()
                {
                    x = Convert.ToInt32(Hero.PositionX),
                    y = Convert.ToInt32(Hero.PositionY)
                });
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RouteRecordTimer.Enabled = false;

            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"RecordRoute.txt"))
            {
                for (int Route = 0; Route < RouteRecord.GrindRoutes.Count; ++Route)
                {
                    GrindRouteFile.WriteLine(RouteRecord.GrindRoutes[Route].x + "," + RouteRecord.GrindRoutes[Route].y + "," + RouteRecord.GrindRoutes[Route].SleepRun);
                }
                GrindRouteFile.Close();
                MessageBox.Show("Маршрут сохранен");
           
            }
            
            //Application.Restart();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text += "0";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GrindBot.SetForegroundWindow(Program.ArcheageWindowHandle);
            GrindBot.SetKeyboardState(new byte[256]);
            SendKeys.Send("W");
            //Thread.Sleep(200);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void label18_Click(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label25_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            RouteRecordTimer.Enabled = false;
            Application.Restart();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

      //      TimeSpan current_time = DateTime.Now.TimeOfDay;
      //       if (GetAsyncKeyState(49)!=0) ;
           //  {
//
//                  listBox1.Items.Insert(1, "1");
            // }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (GetAsyncKeyState(49) != 0)
            {
                Hero.Target = false;
                Enemy.OnScreen = false;
                // System.Threading.Thread.Sleep(2000);
            }

            if (ShutdowdCheck.Checked == true)
            {
                ShutDownTimer.Enabled = true;
            }
            if ((Enemy.OnScreen == true) && (Hero.Target == true))
            {
                Hero.Action = "Battle";
            }
            else
            {
                if((Hero.Health>Hero.healhp) && (Hero.Mana>Hero.healmp)&&(deadtik != false))
                {
                Hero.Action = "RunOnLocation";
                }
            }

            if (Hero.Action == "InPosition")
            {
                button3.PerformClick();
            }
           // if (Hero.Health <= 0)
           // {
           //     label36.Text = "Dead";
           //     System.Threading.Thread.Sleep(380000);
           //     button3.PerformClick();
           // }
        }
        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pak_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(112) != 0)
            {
               // Hero.Target = false;
               // Enemy.OnScreen = false;
                // System.Threading.Thread.Sleep(2000);
            }
           // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F1, (IntPtr)0);
            if ((GrindBot.ToCoordX == 10) && (GrindBot.ToCoordY == 10))
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
          
                ActionTimer.Enabled = false;
                ViewDirectionTimer.Enabled = false;
                button16.PerformClick();
                Hero.Target = true;
                Enemy.OnScreen = true;
                
               
                      
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        private void EnemyHealthBar_Tick(object sender, EventArgs e)
        {
           // if (mainmobhp.Enabled == true)
           // {
           //     EnemyHealthBar.Enabled = false;
           // }
            label37.Text = mob.ToString();
            mob = false;
            Listboxtimer.Enabled = true;


            if ((Hero.Health > 240) && (Hero.Mana > 240))
            {
                Hero.Target = false;
                Enemy.OnScreen = false;
            }
            else
            {
                Hero.Target = true;
                Enemy.OnScreen = true;
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);
                //System.Threading.Thread.Sleep(150);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);



            }
            //FightTimer.Enabled = true;


             
            int Rmax = 196;
            int Gmax = 87;
            int Bmax = 81;

            int Rmin = 130;
            int Gmin = 20;
            int Bmin = 20;

           // int Rmmax = 48;
           // int Gmmax = 77;
           // int Bmmax = 187;

           // int Rmmin = 42;
           // int Gmmin = 59;
           // int Bmmin = 128;

           
            Bitmap im = (Bitmap)this.pictureBox1.Image;
            //Hero.jhp = 57;

            for (Hero.ihp = 0; Hero.ihp < 1024; Hero.ihp++)
            {
                if (mainmobhp.Enabled == true)
                {
                    break;
                }
                for (Hero.jhp = 0; Hero.jhp < 768; Hero.jhp++)
                //for (j = 70; j < 80; j++)
                {

                    Color color = im.GetPixel(Hero.ihp, Hero.jhp);

                    if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
                    {
                        if ((gather == false) && (puck == false))
                        {
                            mainmobhp.Enabled = true;
                            Hero.Target = true;
                            Enemy.OnScreen = true;
                            mob = true;
                            EnemyHealthBar.Enabled = false;
                            break;
                            // EnemyHealthBar.Enabled = false;

                        }




                        //MessageBox.Show(color.A.ToString() + "\n R is " + color.R.ToString() + "\n G is " + color.G.ToString() + "\n B is " + color.B.ToString() + "\n i is " + i + "\n j is " + j);

                    }




                    //System.Threading.Thread.Sleep(100);
                    if ((mob == true))
                    {

                        ///////////////////////////////////////

                        ///<<<<<<<<<<<<<<<<<<<
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                        //System.Threading.Thread.Sleep(150);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);


                        ///<<<<<<<<<<<<<<<<<<
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                        //System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                        ///<<<<<<<<<<<<<<<<<<
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                       // System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                        ///<<<<<<<<<<<<<<<<<<
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                        //System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                        ///<<<<<<<<<<<<<<<<<
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                       // System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);

                        //////////////////////////////////////




                        if ((Game.ButtonF == true) && (puck = false))
                        {
                            if (gather == true)
                            {
                                //Hero.Action = "Working";
                                Thread.Sleep(5000);
                            }
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                            System.Threading.Thread.Sleep(150);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                        }


                        mob = false;
                    }

                    //MessageBox.Show(color.A.ToString() + "\n R is " + color.R.ToString() + "\n G is " + color.G.ToString() + "\n B is " + color.B.ToString());
                }
            }
            if ((Hero.Target == false) && (Enemy.OnScreen == false))
            {
                if ((gather == true) && (Game.ButtonF == true))
                {
                    listBox1.Items.Add("Собираю...");
                    loot++;
                    Hero.Action = "Working";
                    Thread.Sleep(7000);
                    listBox1.Items.Add("Всего собрано "+loot);
                }
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                System.Threading.Thread.Sleep(150);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
            }



            if ((mob == false) && (Hero.Health > Hero.healhp) && (Hero.Mana > Hero.healmp) && (gather == false) && (puck == false))
            {

                if (Game.ButtonF == true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                    //System.Threading.Thread.Sleep(150);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                }

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                //System.Threading.Thread.Sleep(500);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                //System.Threading.Thread.Sleep(3000);

            }
           
        }
      
         ////////////////////////////////////////////////////////////////////////////////////////////
 
        private void FightTimer_Tick(object sender, EventArgs e)
        {
            mob = false;

            if ((Hero.Health < Hero.healhp) || (Hero.Mana < Hero.healmp))
            {
                //System.Threading.Thread.Sleep(2500);
            }
            //System.Threading.Thread.Sleep(100);
            if ( (mob == true) )
            {
                //if (checkBox1.Checked == true)
               // {
                //    System.Threading.Thread.Sleep(2000);
               // }
                    ///////////////////////////////////////

                    ///<<<<<<<<<<<<<<<<<<<
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                   // System.Threading.Thread.Sleep(150);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);


                    ///<<<<<<<<<<<<<<<<<<
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                   // System.Threading.Thread.Sleep(50);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                    ///<<<<<<<<<<<<<<<<<<
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                  //  System.Threading.Thread.Sleep(50);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                    ///<<<<<<<<<<<<<<<<<<
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                  //  System.Threading.Thread.Sleep(50);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);

                    //////////////////////////////////////
                



                    if (Game.ButtonF == true)
                    {
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                       // System.Threading.Thread.Sleep(150);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                    }

                    mob = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            PlaceFarmTimer.Enabled = false;
            ShutDownTimer.Enabled = false; ;
            DeathTimer.Enabled = false;
            Secundomer.Enabled = false;
            BufTimer.Enabled = false;
            //LootTimer.Enabled = true;
            Heal.Enabled = false;
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = false;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = false;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = false;
            Hero.Action = "Pause";
            label15.Text = "Pause";
            timer2.Enabled = false;
            EnemyHealthBar.Enabled = false;
            button8.Visible = false;
            button27.Visible = true;
            button3.Visible = true;
            mainmobhp.Enabled = false;
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.A, (IntPtr)0);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = false;
            TargetTimer.Enabled = false;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = false;
            HeroTimer.Enabled = false;
            GameTimer.Enabled = false;
            Hero.Action = "Stoped";
            timer2.Enabled = false;
            EnemyHealthBar.Enabled = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button10_Click(object sender, EventArgs e)
        {


            this.Height = 208;
            this.Width = 195;
            button10.Visible = false;
            button11.Visible = true;
            this.Controls.Add(this.listBox1);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            label32.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            label36.Visible = false;
            label26.Visible = false;
            label15.Visible = false;
            label30.Visible = false;
            label16.Visible = false;
            label37.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label25.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label4.Visible = false;
            label9.Visible = false;
            label31.Visible = false;
            label17.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            this.Height = 216;
            this.Width = 600;
            button11.Visible = false;
            button10.Visible = true;
            this.tabPage7.Controls.Add(this.listBox1);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            label32.Visible = true;
            label8.Visible = true;
            label10.Visible = true;

            label26.Visible = true;
            label15.Visible = true;
            label30.Visible = true;
            label16.Visible = true;
            label37.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label25.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label4.Visible = true;
            label9.Visible = true;
            label31.Visible = true;
            label17.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hero.xywalking = checkBox4.Checked;
            gather = true;
            Route.LoadGrindRoute("RecordGatherRoute.txt");
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            Hero.Action = "RunOnLocation";
            timer2.Enabled = true;
            EnemyHealthBar.Enabled = true;
            button12.Visible = false;
            button15.Visible = true; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            //ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            //TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            //EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            RouteRecordTimer.Enabled = true;
            //timer2.Enabled = true;
            button13.Visible = false;
            button14.Visible = true; 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button13.Visible = true; 

            RouteRecordTimer.Enabled = false;

            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"RecordGatherRoute.txt"))
            {
                for (int Route = 0; Route < RouteRecord.GrindRoutes.Count; ++Route)
                {
                    GrindRouteFile.WriteLine(RouteRecord.GrindRoutes[Route].x + "," + RouteRecord.GrindRoutes[Route].y + "," + RouteRecord.GrindRoutes[Route].SleepRun);
                }
                GrindRouteFile.Close();
                MessageBox.Show("Маршрут сохранен");

            }
         
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = false;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = false;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = false;
            Hero.Action = "Pause";
            timer2.Enabled = false;
            EnemyHealthBar.Enabled = false;
            button12.Visible = true;
            button15.Visible = false; 
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pak.Enabled = false;
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = false;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = false;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = false;
            Hero.Action = "Pause";
            timer2.Enabled = false;
            EnemyHealthBar.Enabled = false;
            button1.Visible = true;
            button16.Visible = false;
            button20.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            button17.Visible = false;
            button18.Visible = true;

            RouteRecordTimer.Enabled = false;

            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"RecordPackA=BRoute.txt"))
            {
                
                for (int Route = 0; Route < RouteRecord.GrindRoutes.Count; ++Route)
                {
                    GrindRouteFile.WriteLine(RouteRecord.GrindRoutes[Route].x + "," + RouteRecord.GrindRoutes[Route].y + "," + RouteRecord.GrindRoutes[Route].SleepRun);
                }
                GrindRouteFile.WriteLine(10 + "," + 10 + "," + 0);
                GrindRouteFile.Close();
                MessageBox.Show("Маршрут сохранен");

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            record = Convert.ToInt32(numericUpDown11.Value);
            button17.Visible = true;
            button18.Visible = false;
            //ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            //TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            //EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            RouteRecordTimer.Enabled = true;
            //timer2.Enabled = true;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            Hero.xywalking = checkBox3.Checked;
            puck = true;
            Route.LoadGrindRoute("RecordPackB=ARoute.txt");
            ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            Hero.Action = "RunOnLocation";
            timer2.Enabled = true;
            EnemyHealthBar.Enabled = true;
            button1.Visible = false;
            button16.Visible = true;
            button20.Visible = false;
            pak.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            record = Convert.ToInt32(numericUpDown11.Value);
            button22.Visible = true;
            button21.Visible = false;
            //ActionTimer.Enabled = true;
            ViewDirectionTimer.Enabled = true;
            //TargetTimer.Enabled = true;
            InterfaceTimer.Enabled = true;
            //EnemyTimer.Enabled = true;
            HeroTimer.Enabled = true;
            GameTimer.Enabled = true;
            RouteRecordTimer.Enabled = true;
            //timer2.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Visible = false;
            button21.Visible = true;

            RouteRecordTimer.Enabled = false;

            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"RecordPackB=ARoute.txt"))
            {

                for (int Route = 0; Route < RouteRecord.GrindRoutes.Count; ++Route)
                {
                    GrindRouteFile.WriteLine(RouteRecord.GrindRoutes[Route].x + "," + RouteRecord.GrindRoutes[Route].y + "," + RouteRecord.GrindRoutes[Route].SleepRun);
                }
                GrindRouteFile.WriteLine(10 + "," + 10 + "," + 0);
                GrindRouteFile.Close();
                MessageBox.Show("Маршрут сохранен");
            }




        }

        private void mainmobhp_Tick(object sender, EventArgs e)
        {
            
            DeathTimer.Enabled = true;
            Listboxtimer.Enabled = true;
            ////////////////проверка дружественного таргета///////////
        /*    int Rmax1 = 140;
            int Rmin1 = 30;
            int Gmax1 = 190;
            int Gmin1 = 100;
            int Bmax1 = 100;
            int Bmin1 = 20;
            Bitmap im1 = (Bitmap)this.pictureBox1.Image;
            Color color8 = im1.GetPixel(Hero.ihp+3, Hero.jhp);
            if ((color8.R > Rmin1) && (color8.R < Rmax1) && (color8.G > Gmin1) && (color8.G < Gmax1) && (color8.B > Bmin1) && (color8.B < Bmax1))
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);

            }
      */      ////////////////проверка дружественного таргета///////////
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);            
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
            
            int Rmax = 200;
            int Gmax = 100;
            int Bmax = 100;

            int Rmin = 130;
            int Gmin = 20;
            int Bmin = 20;


            if ((Hero.Health > Hero.healhp) && (Hero.Mana > 250))
            {
                Heal.Enabled = false;
            }

            Color color = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);

            if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
            {
            
                if ((batcheck2 == true))
                {
                    listBox1.Items.Add(">>>>>>>" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "<<<<<<<<");
                    listBox1.Items.Add("В бою");
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                    batcheck2 = false;
                }
                if (PlaceMobFarm == true)
                {
                    PlaceFarmTimer.Enabled = false;
                }
                batcheck = true;
                Hero.Action = "Battle";
                Hero.mob = true;
                Hero.Target = true;
                Enemy.OnScreen = true;
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.A, (IntPtr)0);
                //mob = true;
                // System.Threading.Thread.Sleep(150);
                
                Battletime.Enabled = true;
                Color color2 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + 1, Hero.jhp);
                if ((color2.R > Rmin) && (color2.R < Rmax) && (color2.G > Gmin) && (color2.G < Gmax) && (color2.B > Bmin) && (color2.B < Bmax))
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                }
                Color color3 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);
                  if ((color3.R > Rmin) && (color3.R < Rmax) && (color3.G > Gmin) && (color3.G < Gmax) && (color3.B > Bmin) && (color3.B < Bmax))
                  {
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                  }
                  Color color4 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);
                  if ((color4.R > Rmin) && (color4.R < Rmax) && (color4.G > Gmin) && (color4.G < Gmax) && (color4.B > Bmin) && (color4.B < Bmax))
                  {
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                  }
                  Color color5 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);
                  if ((color5.R > Rmin) && (color5.R < Rmax) && (color5.G > Gmin) && (color5.G < Gmax) && (color5.B > Bmin) && (color5.B < Bmax))
                  {
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                  }
                  Color color6 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);
                  if ((color6.R > Rmin) && (color6.R < Rmax) && (color6.G > Gmin) && (color6.G < Gmax) && (color6.B > Bmin) && (color6.B < Bmax))
                  {
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                  }
                  Color color7 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + Convert.ToInt32(numericUpDown9.Value), Hero.jhp);
                  if ((color7.R > Rmin) && (color7.R < Rmax) && (color7.G > Gmin) && (color7.G < Gmax) && (color7.B > Bmin) && (color7.B < Bmax))
                  {
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
                      SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
                  }
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);

                if ((Hero.Health < Hero.healhp) && checkBox5.Checked)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                }

                if (Hero.Health < 50)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F2, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F2, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
                }


            }

            else
            {


                //while (Enemy.OnScreen == true)
                if ((Enemy.OnScreen == true) && (Hero.mob == true))
                {
                    if (batcheck == true)
                    {
                        Battletime.Enabled = false;
                        mobchecker++;
                        listBox1.Items.Add(">>>>>>>" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "<<<<<<<<");
                        listBox1.Items.Add("Бой окончен.Мобов Убито:" + mobchecker);
                        
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.SelectedIndex = -1;
                        batcheck = false;
                        batcheck2 = true;
                        if ((Hero.Health < Hero.healhp) || (Hero.Mana < Hero.healmp))
                        {
                            listBox1.Items.Add("Восстанавливаю HP/MP");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            listBox1.SelectedIndex = -1;
                            Heal.Enabled = true;
                        }
                        else 
                        { 
                            listBox1.Items.Add(">> ХП и МП в норме <<");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            listBox1.SelectedIndex = -1;
                             
                        }
                    }
                   // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                   // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                    
                   
                }
                if ((Hero.Health > Hero.healhp) && (Hero.Mana > Hero.healmp))
                {
                    Hero.Target = false;
                    Enemy.OnScreen = false;
                }
                Hero.mob = false;
                if ((Hero.mob == false) && (Hero.Health > Hero.healhp) && (Hero.Mana > Hero.healmp) && (gather == false) && (puck == false))
            {
                if (PlaceMobFarm == true)
                {
                    if ((GrindBot.ToCoordX == Hero.PositionX) && (GrindBot.ToCoordY == Hero.PositionY))
                    {
                        ActionTimer.Enabled = false;
                        ViewDirectionTimer.Enabled = false;
                        PlaceFarmDeath = false;
                    }
                    if (PlaceFarmDeath == false)
                    {
                        PlaceFarmTimer.Enabled = true;
                    }
                }
                Heal.Enabled = false;
                Hero.Target = false;
                Enemy.OnScreen = false;
                if (Game.ButtonF == true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                    //System.Threading.Thread.Sleep(150);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                }
                else
                    {
                       SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                      
                       SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
         
                    }
                //SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                //SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                //System.Threading.Thread.Sleep(500);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                //System.Threading.Thread.Sleep(3000);
                     Color color1 = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp, Hero.jhp);

                     if ((color1.R > Rmin) && (color1.R < Rmax) && (color1.G > Gmin) && (color1.G < Gmax) && (color1.B > Bmin) && (color1.B < Bmax))
                     {

                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D, (IntPtr)0);
     
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                         SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D, (IntPtr)0);
                     }

            }
                    

                    //System.Threading.Thread.Sleep(2000);
                    //EnemyHealthBar.Enabled = true;
                    //TEST.Enabled = false;
                
            }




            // MessageBox.Show(color.A.ToString() + "\n R is " + color.R.ToString() + "\n G is " + color.G.ToString() + "\n B is " + color.B.ToString() + "\n i is " + i + "\n j is " + j);

                    
        }

        private void Heal_Tick(object sender, EventArgs e)
        {
            if ((Hero.Health < Hero.healhp) || (Hero.Mana < Hero.healmp))
            {
                timer2.Enabled = false;
                mainmobhp.Enabled = false;
            }
            int Rmax = 196;
            int Gmax = 87;
            int Bmax = 81;

            int Rmin = 134;
            int Gmin = 29;
            int Bmin = 29;

            if ((Hero.mob = true) && (Hero.Health > 240) && (Hero.Mana > 240))
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);

            }
            if ((Hero.Health > Hero.currenthp) || (Hero.Mana > Hero.currentmp))
            {
                Color color = ScreenCapture.LockBitmap.Screen.GetPixel(Hero.ihp + 1, Hero.jhp);

                if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
                {
                    mainmobhp.Enabled = true;
                    timer2.Enabled = true;
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                    listBox1.Items.Add("<Восстановление прервано>");
                    listBox1.Items.Add("<Добиваю моба>");
                    listBox1.Items.Add("Текущее HP >> " + Hero.Health);
                    listBox1.Items.Add("Текущее MP >> " + Hero.Mana);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;



                }
                if (Hero.Action == "RunOnLocation")
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                }
                if ((Hero.Health < 240)&&(Hero.Health<Hero.Mana))
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);
                }
                else if ((Hero.Mana < 240)&&(Hero.Health>Hero.Mana))
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D9, (IntPtr)0);
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D9, (IntPtr)0);
                }
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);

            }
            Hero.currenthp = Hero.Health;
            Hero.currentmp = Hero.Mana;
            if ((Hero.Health > 240) && (Hero.Mana > 240))
            {
                mainmobhp.Enabled = true;
                timer2.Enabled = true;
                Hero.Action = "RunOnLocation";
                Heal.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Listboxtimer_Tick(object sender, EventArgs e)
        {

            if (Hero.Action == "RunOnLocation")
            {

                if ((CoordinX != GrindBot.ToCoordX) || (CoordinY != GrindBot.ToCoordY))
                {
                    listBox1.Items.Add("Ищу координаты : >> " + GrindBot.ToCoordX.ToString() + "," + GrindBot.ToCoordY.ToString() + " <<");
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                    CoordinX = GrindBot.ToCoordX;
                    CoordinY = GrindBot.ToCoordY;
                }
            }
            
            if (Hero.Action == "InPosition")
            {
                listBox1.Items.Add("Прибыл на место"); 
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }

        }

        private void Battletime_Tick(object sender, EventArgs e)
        {
            if (batcheck2 == false)
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);
            }   
            
        }



        private void zasadka_Tick(object sender, EventArgs e)
        {
            
            progressBar3.Maximum = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text));
            label43.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text)).ToString();
            
            
            SetCursorPos(509, 350);
            //MessageBox.Show("Установите камеру вертикально на максимальную дистунцию , курсор установлен в месте первой посадки");
            System.Threading.Thread.Sleep(5000);
            bool storona1 = false;
            bool storona2 = true;
            bool storona = true;

            int i;
            int j;
            zasadkaend = false;
            ztamer.Enabled = true;
            for (j = 0; j < (Convert.ToInt32(textBox5.Text)-1); j++)
            {

                
                for (i = 0; i < Convert.ToInt32(textBox4.Text); i++)
                {
                    k++;
                    progressBar3.Value = k;
                    label41.Text = k.ToString();
                    if (storona1 == true)
                    {
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                        SetCursorPos(509, 350);
                        System.Threading.Thread.Sleep(1500);

                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_LBUTTONDOWN, (IntPtr)0, (IntPtr)0);
                        System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_LBUTTONUP, (IntPtr)0, (IntPtr)0);
   
                                        
                        System.Threading.Thread.Sleep(2000);
                        if (i != Convert.ToInt32(textBox4.Text)-1)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Q, (IntPtr)0);
                            System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Q, (IntPtr)0);
                        }
                            storona = false;
                    }
                    if (storona2 == true)
                    {
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                        SetCursorPos(509, 350);
                        System.Threading.Thread.Sleep(1500);
                      

                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_LBUTTONDOWN, (IntPtr)0, (IntPtr)0);
                        System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_LBUTTONUP, (IntPtr)0, (IntPtr)0);

                   

                        System.Threading.Thread.Sleep(2000);
                        if (i != Convert.ToInt32(textBox4.Text)-1)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.E, (IntPtr)0);
                            System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.E, (IntPtr)0);
                        }
                            storona = true;
                    }

                }
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                if (storona == false)
                {
                      
                    storona1 = false;
                    storona2 = true;
                }
                else
                {
                     
                    storona2 = false;
                    storona1 = true;
                }


            }
            
           // MessageBox.Show("Засадка завершена");
           // zasadka.Enabled = false;
            //System.Threading.Thread.Sleep(20000);
            zasadkaend = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            k = 0;
            ztamer.Enabled = false;
            zasadka.Enabled = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отключите в настройках игры передвижение мышью.Положите в слот 1 семена .Установите камеру вертикально , на максимальную дистанцию.Далее переместите персонажа в левый нижний угол территории , которую необходимо засадить, и повернитесь лицом в сторону засадки .Затем можете запускать бота");
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void ztamer_Tick(object sender, EventArgs e)
        {
           
            //label41.Text = k.ToString();
            //progressBar3.Value = k;
            if (zasadkaend == true)
            {

                zasadka.Enabled = false;
                sbor.Enabled = false;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void sbor_Tick(object sender, EventArgs e)
        {
            
            k = 0;
            progressBar3.Maximum = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text));
            label43.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text)).ToString();
          
            bool storona1 = false;
            bool storona2 = true;
            bool storona = true;

            int i;
            int j;
            zasadkaend = false;
            ztamer.Enabled = true;
            for (j = 0; j < Convert.ToInt32(textBox5.Text); j++)
            {


                for (i = 0; i < Convert.ToInt32(textBox4.Text); i++)
                {
                    k++;
                    progressBar3.Value = k;
                    label41.Text = k.ToString();
                    if (storona1 == true)
                    {
                        System.Threading.Thread.Sleep(1000);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                        System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                        System.Threading.Thread.Sleep(5500);
                        if (i != Convert.ToInt32(textBox4.Text) - 1)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Q, (IntPtr)0);
                            System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Q, (IntPtr)0);
                        }
                        storona = false;
                    }
                    if (storona2 == true)
                    {
                        System.Threading.Thread.Sleep(1000);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                        System.Threading.Thread.Sleep(50);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                    


                        System.Threading.Thread.Sleep(5500);
                        if (i != Convert.ToInt32(textBox4.Text) - 1)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.E, (IntPtr)0);
                            System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.E, (IntPtr)0);
                        }
                        storona = true;
                    }

                }
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                System.Threading.Thread.Sleep(Convert.ToInt32(textBox6.Text));
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                if (storona == false)
                {
                   
                    storona1 = false;
                    storona2 = true;
                }
                else
                {
                   
                    storona2 = false;
                    storona1 = true;
                }


            }

            // MessageBox.Show("Засадка завершена");
            // zasadka.Enabled = false;
            //System.Threading.Thread.Sleep(20000);
            zasadkaend = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ztamer.Enabled = false;
            sbor.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LootTimer_Tick(object sender, EventArgs e)
        {
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
            System.Threading.Thread.Sleep(50);
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
              
        }

        private void FailedLoot_Tick(object sender, EventArgs e)
        {
            if((Hero.Action=="RunOnLocation"))
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                System.Threading.Thread.Sleep(50);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
         
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void SquareTimer_Tick(object sender, EventArgs e)
        {
            if ((numericUpDown4.Value > 1) && (numericUpDown5.Value > 1))
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                ViewDirectionTimer.Enabled = true;
                InterfaceTimer.Enabled = true;
                HeroTimer.Enabled = true;
                GameTimer.Enabled = true;

                using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"SquareRoute.txt"))
                {

                    if ((Hero.PositionX > 0) && (Hero.PositionY > 0))
                    {
                        //GrindRouteFile.WriteLine(Hero.PositionX + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine((Hero.PositionX + numericUpDown4.Value) + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + (Hero.PositionY + numericUpDown5.Value) + "," + 0);
                        GrindRouteFile.WriteLine((Hero.PositionX - numericUpDown4.Value) + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + (Hero.PositionY - numericUpDown5.Value) + "," + 0);
                        GrindRouteFile.Close();
                        // MessageBox.Show("Маршрут сохранен");
                        deadtik = true;
                        if ((BufCheck1.Checked == true) || (BufCheck2.Checked == true) || (BufCheck2.Checked == true))
                        {
                            StartBuf.Enabled = true;
                        }
                        Secundomer.Enabled = true;
                        BufTimer.Enabled = true;
                        
                        Time = 0;
                        CurrentTime1 = 0;
                        CurrentTime2 = 0;
                        CurrentTime3 = 0;
                        Hero.xywalking = checkBox1.Checked;
                        Hero.healhp = (int)numericUpDown2.Value;
                        Hero.healmp = (int)numericUpDown3.Value;
                        Route.LoadGrindRoute("SquareRoute.txt");
                        FailedLoot.Enabled = true;
                        //LootTimer.Enabled = true;
                        ActionTimer.Enabled = true;
                        ViewDirectionTimer.Enabled = true;
                        TargetTimer.Enabled = true;
                        InterfaceTimer.Enabled = true;
                        EnemyTimer.Enabled = true;
                        HeroTimer.Enabled = true;
                        GameTimer.Enabled = true;
                        Hero.Action = "RunOnLocation";
                        timer2.Enabled = true;
                        if (mobsetting == true)
                        {
                            EnemyHealthBar.Enabled = false;
                            mainmobhp.Enabled = true;
                        }
                        else
                        {
                            EnemyHealthBar.Enabled = true;
                        }
                        button3.Visible = false;
                        button8.Visible = true;
                        SquareTimer.Enabled = false;

                    }

                }
            }
            else System.Diagnostics.Process.GetCurrentProcess().Kill();                                                            
        }

        private void Secundomer_Tick(object sender, EventArgs e)
        {
            
            
            Time++;

            
        }

        private void BufCheck1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BufCheck2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BufCheck3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void BufTimer_Tick(object sender, EventArgs e)
        {

            
            
                if (BufCheck1.Checked == true)
                {
                    if (CurrentTime1 == 0)
                    {
                        CurrentTime1 = Time;
                        // MessageBox.Show("+CurrentTime1+CurrentTime2+CurrentTime3+Time+");
                    }
                    if (Time > (CurrentTime1 + numericUpDown6.Value))
                    {
                        if (baflist1 == true)
                        {
                            listBox1.Items.Add(">> Время бафа 1 вышло <<");
                            baflist1 = false; ;
                        }
                        if (batcheck2 == false)
                        {
                            listBox1.Items.Add(">> Ожидание выхода боя... <<");
                        }
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.SelectedIndex = -1;
                        timer2.Enabled = false;
                       
                        if (Battletime.Enabled == false)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            System.Threading.Thread.Sleep(1000);
                            Hero.Action = "BufTime";
                            listBox1.Items.Add(">> Использую Баф 1 <<");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            listBox1.SelectedIndex = -1;
                            baflist1 = true;
                            
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);
                            
                            System.Threading.Thread.Sleep(3000);
                            CurrentTime1 = 0;
                            if ((Hero.Health > 240) && (Hero.Mana > 240))
                            {
                                timer2.Enabled = true;
                                Hero.Action = "RunOnLocation";
                            }
                        }
                    }
                }
                if (BufCheck2.Checked == true)
                {
                    if (CurrentTime2 == 0)
                    {
                        CurrentTime2 = Time;
                    }
                    if (Time > (CurrentTime2 + numericUpDown7.Value)) 
                    {
                        if (baflist2 == true)
                        {
                            listBox1.Items.Add(">> Время бафа 2 вышло <<");
                            baflist2 = false ;
                        }
                        if (batcheck2 == false)
                        {
                            listBox1.Items.Add(">> Ожидание выхода боя... <<");
                        }
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.SelectedIndex = -1;
                        timer2.Enabled = false;
                       
                        if (Battletime.Enabled == false)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            System.Threading.Thread.Sleep(1000);
                            Hero.Action = "BufTime";
                            listBox1.Items.Add(">> Использую Баф 2 <<");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            listBox1.SelectedIndex = -1;
                            baflist2 = true ;

                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)0xBD, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)0xBD, (IntPtr)0);
                           
                            System.Threading.Thread.Sleep(3000);
                            CurrentTime2 = 0;
                            if ((Hero.Health > 240) && (Hero.Mana > 240))
                            {
                                timer2.Enabled = true;
                                Hero.Action = "RunOnLocation";
                            }
                        }
                    }
                }
                if (BufCheck3.Checked == true)
                {
                    if (CurrentTime3 == 0)
                    {
                        CurrentTime3 = Time;
                    }
                    if (Time > (CurrentTime3 + numericUpDown8.Value)) 
                    {
                        if (baflist3 == true)
                        {
                            listBox1.Items.Add(">> Время бафа 3 вышло <<");
                            baflist3 = false;
                        }
                        if (batcheck2 == false)
                        {
                            listBox1.Items.Add(">> Ожидание выхода боя... <<");
                        }
                        listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        listBox1.SelectedIndex = -1;
                        timer2.Enabled = false;

                        if (Battletime.Enabled == false)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                            System.Threading.Thread.Sleep(1000);
                            Hero.Action = "BufTime";
                            listBox1.Items.Add(">> Использую Баф 3 <<");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            listBox1.SelectedIndex = -1;
                            baflist3 = true;

                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)0xBB, (IntPtr)0);
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)0xBB, (IntPtr)0);

                            System.Threading.Thread.Sleep(3000);
                            CurrentTime3 = 0;
                        }
                            if ((Hero.Health > 240) && (Hero.Mana > 240))
                            {
                               
                                timer2.Enabled = true;
                                Hero.Action = "RunOnLocation";
                            }
                        
                    }
                    
                }
            

        }

        private void StartBuf_Tick(object sender, EventArgs e)
        {
            baflist1 = true;
            baflist2 = true;
            baflist3 = true;
            if (BufCheck1.Checked == true)
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                System.Threading.Thread.Sleep(1000);
                Hero.Action = "BufTime";
                listBox1.Items.Add(">> Использую Баф 1 <<");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);

                System.Threading.Thread.Sleep(3000);
                CurrentTime1 = 0;
            }

            ///////////////////////////////////////////////////

            if (BufCheck2.Checked == true)
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                System.Threading.Thread.Sleep(1000);
                Hero.Action = "BufTime";
                listBox1.Items.Add(">> Использую Баф 2 <<");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)0xBD, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)0xBD, (IntPtr)0);

                System.Threading.Thread.Sleep(3000);
                CurrentTime2 = 0;
            }
            /////////////////////////////////////////////////////
            if (BufCheck3.Checked == true)
            {
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Space, (IntPtr)0);
                System.Threading.Thread.Sleep(1000);
                Hero.Action = "BufTime";
                listBox1.Items.Add(">> Использую Баф 3 <<");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;

                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)0xBB, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)0xBB, (IntPtr)0);

                System.Threading.Thread.Sleep(3000);
                CurrentTime3 = 0;
            }
            StartBuf.Enabled = false;

        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            bool breaker;
            int Rmax = 146;
            int Gmax = 47;
            int Bmax = 41;

            int Rmin = 120;
            int Gmin = 20;
            int Bmin = 20;
            breaker = true;


           
            Bitmap im = (Bitmap)this.pictureBox1.Image;

            for (Hero.jhp = 10; Hero.jhp < ScreenCapture.LockBitmap.Screen.Height-10; Hero.jhp++)
            {


                for (Hero.ihp = 10; Hero.ihp < ScreenCapture.LockBitmap.Screen.Width-10; Hero.ihp++)
                {

                    Color color = im.GetPixel(Hero.ihp, Hero.jhp);

                    if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            color = im.GetPixel(Hero.ihp + i, Hero.jhp);
                            if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
                            {
                                if (breaker == true)
                                {
                                    using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"Setting.txt"))
                                    {


                                        GrindRouteFile.WriteLine(Hero.ihp);
                                        GrindRouteFile.WriteLine(Hero.jhp);
                                        //GrindRouteFile.WriteLine(numericUpDown9.Value);
                                        GrindRouteFile.Close();

                                        MessageBox.Show("Панель моба найдена и сохранена.\nТребуется перезагрузка бота");
                                        Process.GetCurrentProcess().Kill();
                                        breaker = false;



                                    }
                                }
                                goto loop2;

                            }
                        }
                    }
                }
            }
        loop2: ;
        }
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"Setting.txt"))
            {

                GrindRouteFile.WriteLine(Hero.ihp);
                GrindRouteFile.WriteLine(Hero.jhp);
                GrindRouteFile.WriteLine(Convert.ToInt32(numericUpDown9.Value));
                GrindRouteFile.Close();
                MessageBox.Show("Сохранено");
            }
        }
        private void ShutdowdCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShutDownTimer_Tick(object sender, EventArgs e)
        {
            if (ShutdowdCheck.Checked == true)
            {
                if (timecheck1 == true)
                {
                    CurrentTime4 = Time;
                    timecheck1 = false;

                }
                if(Time > (CurrentTime4 + (Convert.ToInt32(numericUpDown10.Value)*60)))
                {
                    if (shutdownlistbox == true)
                    {
                        listBox1.Items.Add(">> Мобов нафармлено:" + mobchecker + " <<");
                        listBox1.Items.Add(">> Количество смертей: " + dead + " <<");
                        listBox1.Items.Add(">> Выключение питания компьютера <<");
                        listBox1.Items.Add(">> Время>> " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " <<");
                        TextWriter writer = new StreamWriter("ShutDownLog.txt");
                        foreach (var item in listBox1.Items)
                            writer.WriteLine(item.ToString());
                        writer.Close();
                        shutdownlistbox = false;
                    }
                        if (batcheck2 == false)
                        {
                            ShutDown(ShutDownCommand.Shutdown);
                        }

                }
            }
        }
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        public enum ShutDownCommand
        {
            LogOff = 0,
            Shutdown = 1,
            Reboot = 2,
            ForcedLogOff = 4,
            ForcedShutdown = 5,
            ForcedReboot = 6,
            PowerOff = 8,
            ForcedPowerOff = 12

        }

        public void ShutDown(ShutDownCommand cmd)
        {
            ManagementClass W32_OS = new ManagementClass("Win32_OperatingSystem");
            ManagementBaseObject inParams, outParams;

            int result;

            W32_OS.Scope.Options.EnablePrivileges = true;

            foreach (ManagementObject obj in W32_OS.GetInstances())
            {
                inParams = obj.GetMethodParameters("Win32Shutdown");
                inParams["Flags"] = cmd;
                inParams["Reserved"] = 0;

                outParams = obj.InvokeMethod("Win32Shutdown", inParams, null);
                result = Convert.ToInt32(outParams["returnValue"]);

                if (result != 0) throw new Win32Exception(result);
            }
        }
        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com/agebot");
        }

        private void DeathTimer_Tick(object sender, EventArgs e)
        {
            int Rmax = 140;
            int Rmin = 30;
            int Gmax = 190;
            int Gmin = 100;
            int Bmax = 100;
            int Bmin = 20;
            
            if (Hero.Health == 0)
            {
                if (deadtik == true)
                {
                    dead++;
                    listBox1.Items.Add(" >> Умер << ");
                    listBox1.Items.Add(">> Количество смертей: " + dead + " <<");
                    listBox1.Items.Add(" >> До возрождения 8 мин << ");
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    listBox1.SelectedIndex = -1;
                    deadtik = false;
                    currenttime5 = Time;
                    death = true;
                    mainmobhp.Enabled = false;
                }
               // else death = false;
                
                Hero.Action = "Dead";                        
            }

            
            if (deadtik == false)
            {
               // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
               // Hero.Action = "RunOnLocation";
            }

           // if ((death == true)&&(Hero.Health > 10)&&(Hero.Health < 240))

            if ((Time > (currenttime5 + (7 * 60))) && (death == true) )
            {
                if (Hero.Health > 240)
                {

                    ActionTimer.Enabled = true;
                    ViewDirectionTimer.Enabled = true;
                    PlaceFarmDeath = true;

                    listBox1.Items.Add(" >> Возродился << ");
                    deadtik = true;
                    mainmobhp.Enabled = true;
                    Hero.Action = "RunOnLocation";
                    Bitmap im = (Bitmap)this.pictureBox1.Image;
                    Color color = im.GetPixel(Hero.ihp, Hero.jhp);

                    if ((color.R > Rmin) && (color.R < Rmax) && (color.G > Gmin) && (color.G < Gmax) && (color.B > Bmin) && (color.B < Bmax))
                    {
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Escape, (IntPtr)0);
            
                    }
                   // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                     death = false ;
                }
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Hero.Action = "Stop";
            listBox1.Items.Add(">> Мобов нафармлено:" + mobchecker + " <<");
            listBox1.Items.Add(">> Количество смертей: " + dead + " <<");
            listBox1.Items.Add(">> Бот был выключен в " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + " <<");
            TextWriter writer = new StreamWriter("log.txt");
            foreach (var item in listBox1.Items)
                writer.WriteLine(item.ToString());
            writer.Close();

            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Windowmoving = true;

            MXold = e.X;
            MYold = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Windowmoving = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Windowmoving)
            {
                Point tmp = new Point(this.Location.X, this.Location.Y);


                tmp.X += e.X - MXold;
                tmp.Y += e.Y - MYold;

                this.Location = tmp;
            }
        }
        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            ViewDirectionTimer.Enabled = true;
                InterfaceTimer.Enabled = true;
                HeroTimer.Enabled = true;
                GameTimer.Enabled = true;

                using (System.IO.StreamWriter GrindRouteFile = new System.IO.StreamWriter(@"PlaceFarmCoord.txt"))
                {

                    if ((Hero.PositionX > 0) && (Hero.PositionY > 0))
                    {
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.WriteLine(Hero.PositionX + "," + Hero.PositionY + "," + 0);
                        GrindRouteFile.Close();

                        DeathTimer.Enabled = true;
                        deadtik = true;
                        if (checkBox2.Checked == true)
                        {
                            MessageBox.Show("Снемите флажок фарма области и повторите попытку");
                            button8.PerformClick();
                        }
                        else
                        {
                            if ((BufCheck1.Checked == true) || (BufCheck2.Checked == true) || (BufCheck2.Checked == true))
                            {
                                StartBuf.Enabled = true;
                            }
                            Secundomer.Enabled = true;
                            BufTimer.Enabled = true;

                            Time = 0;
                            CurrentTime1 = 0;
                            CurrentTime2 = 0;
                            CurrentTime3 = 0;
                            Hero.xywalking = checkBox1.Checked;
                            Hero.healhp = (int)numericUpDown2.Value;
                            Hero.healmp = (int)numericUpDown3.Value;
                            Route.LoadGrindRoute("PlaceFarmCoord.txt");
                            FailedLoot.Enabled = true;
                            ActionTimer.Enabled = false;
                            ViewDirectionTimer.Enabled = false;
                            TargetTimer.Enabled = true;
                            InterfaceTimer.Enabled = true;
                            EnemyTimer.Enabled = true;
                            HeroTimer.Enabled = true;
                            GameTimer.Enabled = true;
                            PlaceFarmTimer.Enabled = true;
                            label15.Text = "Finding enemy";
                            //timer2.Enabled = true;

                            if (mobsetting == true)
                            {
                                EnemyHealthBar.Enabled = false;
                                mainmobhp.Enabled = true;
                            }
                            else
                            {
                                EnemyHealthBar.Enabled = true;
                            }

                            button3.Visible = false;
                            button27.Visible = false;
                            button8.Visible = true;
                        }
                    }
                }
        }

        private void PlaceFarmTimer_Tick(object sender, EventArgs e)
        {
            PlaceMobFarm = true;
            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.A, (IntPtr)0);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5.pictureGuide = "interface.jpg";
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5.pictureGuide = "setting.jpg";
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try{
            bool FindForm = false;

            for (int y = 10; y < ScreenCapture.LockBitmap.Screen.Height - 100; y++)
            {
                if (FindForm == true) { break; }
                for (int x = 0; x < ScreenCapture.LockBitmap.Screen.Width - 356; x++)
                {
                    if (FindForm == true) { break; }

                    if (VisionForm.FindForm(VisionHero.HeroBars, x, y) != null)
                    {
                        int HeroHpLenght;
                        for (HeroHpLenght = 0; HeroHpLenght < 255; ++HeroHpLenght)
                        {
                            if (VisionForm.FindForm(VisionAlliance.AllianceBars, x + HeroHpLenght + 1, y + 2) != null)
                            {
                                //continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        int HeroManaLenght;
                        for (HeroManaLenght = 0; HeroManaLenght < 255; ++HeroManaLenght)
                        {
                            if (VisionForm.FindForm(VisionAlliance.ManaBars, x + HeroManaLenght + 1, y + 19) != null)
                            {
                                //continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Hero.Mana = HeroManaLenght;
                        progressBar2.Value = HeroManaLenght;

                        Hero.Health = HeroHpLenght;
                        progressBar1.Value = HeroHpLenght;

                        label11.Text = Hero.Health.ToString();
                        label12.Text = Hero.Mana.ToString();
                        if (progressBar1.Value == 255)
                        {
                            xhero = x;
                            yhero = y;
                            herosetting = true;
                            StreamWriter sr = new StreamWriter("SettingHero.txt");
                            sr.WriteLine(herosetting);
                            sr.WriteLine(x);
                            sr.WriteLine(y);
                            sr.Close();
                            MessageBox.Show("Панель найдена и сохранена");
                            break;
                        }
                        
                    }
                }
            
            }
            if (FindForm == false)
            {
              //  MessageBox.Show("Панель не найдена");
            }
            }
            catch (Exception) { }
        }

        private void readHeroSetting()
        {
            StreamReader sr = new StreamReader("SettingHero.txt");

            if (sr.ReadLine() == "True")
            {
                herosetting = true;
                xhero = Convert.ToInt32(sr.ReadLine());
                yhero = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
