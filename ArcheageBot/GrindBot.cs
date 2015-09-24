using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ArcheageBot
{

    class GrindBot
    {

        public const UInt32 KEYEVENTF_EXTENDEDKEY = 1;
        public const UInt32 KEYEVENTF_KEYUP = 2;
        /*
         * Алгоритм
         * -Бежим по маршруту кликая Tab
         * Если появился крип переходим в класс FightBot
         *  
         */
        public static string Direction = "InPosition";
        public static int ToCoordX = 0;
        public static int ToCoordY = 0;
        public static int SleepRun = 0;
        //public static string getkey;
        public static List<Route> GrindRoutes = new List<Route>();

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern int SendMessageA(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool SetKeyboardState(byte[] lpKeyState);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int keys);

       
        public static void Fight()
        {
            while (Enemy.OnScreen == true)
            {
               // keybd_event(0x87, 0, 0, UIntPtr.Zero);
                //keybd_event(0x87, 0, 0x02, UIntPtr.Zero);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                if (Enemy.OnScreen == true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                    Hero.Action = "RunOnLocation";

                    for (int WaitFButtonCount = 0; WaitFButtonCount <= 20; ++WaitFButtonCount)
                    {
                        
                        if ((Game.ButtonF == true) &&  (Enemy.OnScreen == false))////
                        {
                           // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);
                           // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F, (IntPtr)0);

                            System.Threading.Thread.Sleep(150);

                            break;
                        }

                        System.Threading.Thread.Sleep(50);
                    }

                    break;
                }
                else
                {
                    if (Enemy.Distance < 0)
                    {
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);

                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                        System.Threading.Thread.Sleep(200);

                    }
                    else if (Enemy.OnScreen == false)
                    {
                        IntPtr KeyToRotate;
                        if (Enemy.OnScreenPosition == "Left")
                        {
                            KeyToRotate = (IntPtr)System.Windows.Forms.Keys.A;
                        }
                        else
                        {
                            KeyToRotate = (IntPtr)System.Windows.Forms.Keys.D;
                        }

                        for (int RotateCount = 0; RotateCount <= 10; RotateCount++)
                        {
                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, KeyToRotate, (IntPtr)0);
                            System.Threading.Thread.Sleep(50);

                            if (Enemy.OnScreen == false)
                            {
                                break;
                            }
                        }

                        SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, KeyToRotate, (IntPtr)0);
                    }
                }

            }

            Program.NextAction = true;
            Program.Fight.Abort();
        }

        public static void RunOnLocation()
        {
            while (Hero.Action == "RunOnLocation")
            {
                if (Hero.Action == "InPosition")
                {
                    break;
                }
                GrindBot.GetCurrentSkill();
                if (Enemy.OnScreen == true)
                {
                    //System.Threading.Thread.Sleep(2000);
                    //  Hero.Action = "Fight";
                    break;
                }
                if (Hero.xywalking != true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                }
                GrindBot.GetCurrentSkill();
                GrindBot.GetCurrentRoute();

                if (GrindBot.SleepRun > 0)
                {
                    System.Threading.Thread.Sleep(GrindBot.SleepRun);
                    GrindBot.SleepRun = 0;
                }
                else
                {
                    GrindBot.GetCurrentSkill();
                    if (Enemy.OnScreen == true) 
                    {
                        //System.Threading.Thread.Sleep(2000);
                      //  Hero.Action = "Fight";
                        break;
                    }
                    else
                    {
                       // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Tab, (IntPtr)0);
                       // SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Tab, (IntPtr)0);

                        if (GrindBot.Direction != Hero.Direction)
                        {
                            IntPtr KeyToRotate = GetKeyToRotate();

                            for (int RotateCount = 0; RotateCount <= 10; RotateCount++)
                            {
                                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, KeyToRotate, (IntPtr)0);
                                
                                System.Threading.Thread.Sleep(100);

                                if (GrindBot.Direction != Hero.Direction)
                                {
                                    Hero.ForceUpdateDirection = true;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, KeyToRotate, (IntPtr)0);

                        }
                        else
                        {
                            if (Hero.xywalking == true)
                            {
                                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                            }
                            Hero.ForceUpdateDirection = false;
                        }

                        System.Threading.Thread.Sleep(200);
                    }

                }

            }
            
           
                SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
            
            Program.NextAction = true;
            Program.RunOnLocation.Abort();
        }

        public static IntPtr GetKeyToRotate()
        {
            string Direction = "Undefined";

            if (GrindBot.Direction == "North")
            {
                if ((Hero.Direction == "North–East") || (Hero.Direction == "East") || (Hero.Direction == "South–East") || (Hero.Direction == "South"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "North–East")
            {
                if ((Hero.Direction == "East") || (Hero.Direction == "South–East") || (Hero.Direction == "South") || (Hero.Direction == "South–West"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "East")
            {
                if ((Hero.Direction == "South–East") || (Hero.Direction == "South") || (Hero.Direction == "South–West") || (Hero.Direction == "West"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "South–East")
            {
                if ((Hero.Direction == "South") || (Hero.Direction == "South–West") || (Hero.Direction == "West") || (Hero.Direction == "North–West"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "South")
            {
                if ((Hero.Direction == "South–West") || (Hero.Direction == "West") || (Hero.Direction == "North–West") || (Hero.Direction == "North"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "South–West")
            {
                if ((Hero.Direction == "West") || (Hero.Direction == "North–West") || (Hero.Direction == "North") || (Hero.Direction == "North–East"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "West")
            {
                if ((Hero.Direction == "North–West") || (Hero.Direction == "North") || (Hero.Direction == "North–East") || (Hero.Direction == "East"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }
            else if (GrindBot.Direction == "North–West")
            {
                if ((Hero.Direction == "North") || (Hero.Direction == "North–East") || (Hero.Direction == "East") || (Hero.Direction == "South–East"))
                {
                    Direction = "Left";
                }
                else
                {
                    Direction = "Right";
                }
            }

            if(Direction == "Left")
            {
                if (Hero.xywalking == true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                }
                    return (IntPtr)System.Windows.Forms.Keys.A;
                //System.Threading.Thread.Sleep(700);
            }
            else if (Direction == "Right")
            {
                if (Hero.xywalking == true)
                {
                    SendMessageA(Program.Archeage, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.W, (IntPtr)0);
                }
                    return (IntPtr)System.Windows.Forms.Keys.D;
                //System.Threading.Thread.Sleep(700);
                
            }
            else
            {
                //Сюда попадать не должно
                return (IntPtr)System.Windows.Forms.Keys.S;
            }
            
        }

        public static void GetCurrentRoute()
        {
            bool FindRoute = false;

            for (int Route = 0; Route < GrindBot.GrindRoutes.Count; ++Route)
            {
                if (GrindBot.GrindRoutes[Route].passed == false)
                {
                    GrindBot.Direction = Navigation.CoordsToDirection(3, GrindBot.GrindRoutes[Route].x, GrindBot.GrindRoutes[Route].y);

                    if (GrindBot.GrindRoutes[Route].SleepRun > 0)
                    {
                        GrindBot.SleepRun = GrindBot.GrindRoutes[Route].SleepRun;
                        GrindBot.GrindRoutes[Route].passed = true;
                    }
                    else
                    {
                        if (GrindBot.Direction == "InPosition")
                        {
                            GrindBot.GrindRoutes[Route].passed = true;
                        }
                        else
                        {
                            FindRoute = true;
                            GrindBot.ToCoordX = GrindBot.GrindRoutes[Route].x;
                            GrindBot.ToCoordY = GrindBot.GrindRoutes[Route].y;
                            break;
                        }
                    }
                }
            }

            if (FindRoute == false)
            {
                for (int Route = 0; Route < GrindBot.GrindRoutes.Count; ++Route)
                {
                    GrindBot.GrindRoutes[Route].passed = false;
                }

                GetCurrentRoute();
            }
        }

        public static void GetCurrentSkill()
        {
            //TimeSpan current_time = DateTime.Now.TimeOfDay;
            if (GetAsyncKeyState(49)!=0) 
            {
                                    
            }
            if (GetAsyncKeyState(50) != 0)
            {
               // Hero.Target = true;
               // Enemy.OnScreen = true;
            }
            if (GetAsyncKeyState(51) != 0)
            {
               // Hero.Target = true;
               // Enemy.OnScreen = true;
            }
            if (GetAsyncKeyState(52) != 0)
            {

            }
            if (GetAsyncKeyState(53) != 0)
            {

            }
            if (GetAsyncKeyState(54) != 0)
            {

            }
            if (GetAsyncKeyState(55) != 0)
            {

            }
            if (GetAsyncKeyState(56) != 0)
            {

            }
            if (GetAsyncKeyState(57) != 0)
            {

            }
            if (GetAsyncKeyState(189) != 0)
            {

            }
            if (GetAsyncKeyState(187) != 0)
            {

            }
            //GetCurrentSkill();
        }

    }
}
