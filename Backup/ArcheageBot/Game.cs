using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ArcheageBot
{
    class Game
    {
        public static string version;
        public static string parse;
        public static bool ButtonF = false;
        public static bool ButtonG = false;
        public static void GetVersion(string PathFile, string xPath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(PathFile);
            foreach (XmlNode node1 in xml.SelectNodes(xPath))
            {
                version = node1.InnerText;
            }
        }
        public static void ParseFile(string PathFile, string xPath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(PathFile);
            foreach (XmlNode node1 in xml.SelectNodes(xPath))
            {
                parse = node1.InnerText;
            }
        }
        public static void FindActionButtons()
        {
            bool FindButtonF = false;
            bool FindButtonG = false;

            for (int y = 550; y < ScreenCapture.LockBitmap.Screen.Height - 190; y++)
            {
                for (int x = 400; x < ScreenCapture.LockBitmap.Screen.Width - 400; x++)
                {
                    if (VisionForm.FindForm(VisionGame.ButtonF, x, y) != null)
                    {
                        FindButtonF = true;
                        Game.ButtonF = true;
                    }
                    if (VisionForm.FindForm(VisionGame.ButtonG, x, y) != null)
                    {
                        FindButtonG = true;
                        Game.ButtonG = true;
                    }
                }
            }

            if (FindButtonF == false)
            {
                Game.ButtonF = false;
            }

            if (FindButtonG == false)
            {
                Game.ButtonG = false;
            }
        }


    }
}
