using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ArcheageBot
{
    class Route
    {
        public int x;
        public int y;
        public int SleepRun = 0;
        public bool passed = false;

        public static void LoadGrindRoute(string Path)
        {
            //StreamReader file = new StreamReader(@Path);
            //StreamWriter file = new StreamWriter(@Path);
            //file.Close();
            
            string[] Routes = System.IO.File.ReadAllLines(@Path);

            GrindBot.GrindRoutes.Clear();
            foreach (string Route in Routes)
            {
                List<string> Attributes = Route.Split(',').ToList();

                GrindBot.GrindRoutes.Add(new Route()
                {
                    x = Convert.ToInt32(Attributes[0]),
                    y = Convert.ToInt32(Attributes[1]),
                    SleepRun = Convert.ToInt32(Attributes[2])
          
                });

                
            }
        }
    }
}
