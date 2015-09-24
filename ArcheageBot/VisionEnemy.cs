using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionEnemy
    {
        public static List<List<VisionForm>> EnemyBars = new List<List<VisionForm>>();
        public static List<List<VisionForm>> EnemyTooltips = new List<List<VisionForm>>();

        public static void LoadEnemyBars()
        {

            /* Заливаем пиксели в переменные, так как форма имеет однообразный цвет */

            int ObjectMaxR = 200;
            int ObjectMinR = 130;
            int ObjectMaxG = 90;
            int ObjectMinG = 20;
            int ObjectMaxB = 90;
            int ObjectMinB = 20;

           

            /* полоса хп с не меняющимся цветом. Проверка идет попиксельно, поэтому определили только 1 пиксель */

            List<VisionForm> EnemyBar1 = new List<VisionForm>
         {

                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
               

            };

            VisionEnemy.EnemyBars.Add(EnemyBar1);

        }

        public static void LoadEnemyTooltips()
        {

            int YellowLineMaxR = 250;
            int YellowLineMinR = 170;
            int YellowLineMaxG = 230;
            int YellowLineMinG = 150;
            int YellowLineMaxB = 100;
            int YellowLineMinB = 30;

            int HealthLineMaxR = 170;
            int HealthLineMinR = 130;
            int HealthLineMaxG = 80;
            int HealthLineMinG = 30;
            int HealthLineMaxB = 60;
            int HealthLineMinB = 10;

            List<VisionForm> EnemyTooltip1 = new List<VisionForm>
            {
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 5, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 6, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },

                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = YellowLineMaxR,
                    MinR = YellowLineMinR,
                    MaxG = YellowLineMaxG,
                    MinG = YellowLineMinG,
                    MaxB = YellowLineMaxB,
                    MinB = YellowLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = YellowLineMaxR,
                    MinR = YellowLineMinR,
                    MaxG = YellowLineMaxG,
                    MinG = YellowLineMinG,
                    MaxB = YellowLineMaxB,
                    MinB = YellowLineMinB,
                },
            };

            List<VisionForm> EnemyTooltip2 = new List<VisionForm>
            {
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -4, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -4, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -5, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -5, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -6, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -6, 
                    MaxR = HealthLineMaxR,
                    MinR = HealthLineMinR,
                    MaxG = HealthLineMaxG,
                    MinG = HealthLineMinG,
                    MaxB = HealthLineMaxB,
                    MinB = HealthLineMinB,
                },


                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = YellowLineMaxR,
                    MinR = YellowLineMinR,
                    MaxG = YellowLineMaxG,
                    MinG = YellowLineMinG,
                    MaxB = YellowLineMaxB,
                    MinB = YellowLineMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = YellowLineMaxR,
                    MinR = YellowLineMinR,
                    MaxG = YellowLineMaxG,
                    MinG = YellowLineMinG,
                    MaxB = YellowLineMaxB,
                    MinB = YellowLineMinB,
                },
            };







            VisionEnemy.EnemyTooltips.Add(EnemyTooltip1);
            VisionEnemy.EnemyTooltips.Add(EnemyTooltip2);

        }
    }
}
