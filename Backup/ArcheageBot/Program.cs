using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Principal;
using System.IO;

namespace ArcheageBot
{
    static class Program
    {
        public static string ArcheageWindowTitle;
        public static bool NextAction = true;
        public static int testint = 0;
        public static Thread RunOnLocation;
        public static Thread Fight;
        public static IntPtr Archeage;
        public static IntPtr ArcheageWindowHandle;

        [STAThread]
        static void Main()
        {

            /* Ищем процесс арчейджа, получаем его TITLE для того чтобы использовать в CaptureScreen */
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (process.ProcessName == "archeage")
                {
                    Program.ArcheageWindowTitle = process.MainWindowTitle;
                    Program.ArcheageWindowHandle = process.MainWindowHandle;

                }
            }
            /////////////////////////
             WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (hasAdministrativeRight == false)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo(); //создаем новый процесс
                processInfo.Verb = "runas"; //в данном случае указываем, что процесс должен быть запущен с правами администратора
                processInfo.FileName = Application.ExecutablePath; //указываем исполняемый файл (программу) для запуска
                try
                {
                    Process.Start(processInfo); //пытаемся запустить процесс
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    //Ничего не делаем, потому что пользователь, возможно, нажал кнопку "Нет" в ответ на вопрос о запуске программы в окне предупреждения UAC (для Windows 7)
                }
                Application.Exit(); //закрываем текущую копию программы (в любом случае, даже если пользователь отменил запуск с правами администратора в окне UAC)
            }
            else //имеем права администратора, значит, стартуем
            {
                ////////////////////////
                Program.Archeage = User32.FindWindow(null, Program.ArcheageWindowTitle);

                /* Загружаем элементы интерфейса для распознавания */

                VisionHeroLocation.LoadHeroCircle();
                VisionTarget.LoadTargetBars();
                VisionEnemy.LoadEnemyBars();
                VisionHero.LoadHeroBars();
                VisionAlliance.LoadAllianceBars();
                VisionAlliance.LoadManaBars();
                VisionEnemy.LoadEnemyTooltips();
                VisionNumbers.LoadDistanceNumbers();
                VisionGame.LoadButtonF();
                VisionGame.LoadButtonG();

                // Route.LoadGrindRoute("RecordRoute.txt");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form3());
            }
        }
    }
}
