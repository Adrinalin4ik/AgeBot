using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionTarget
    {
        public static List<List<VisionForm>> TargetBars = new List<List<VisionForm>>();

        public static void LoadTargetBars()
        {
            /* Заливаем пиксели в переменные, так как форма имеет однообразный цвет */

            int ObjectMaxR = 70;
            int ObjectMinR = 50;
            int ObjectMaxG = 55;
            int ObjectMinG = 35;
            int ObjectMaxB = 30;
            int ObjectMinB = 10;

            int ManaBarMaxR = 50;
            int ManaBarMinR = 0;
            int ManaBarMaxG = 40;
            int ManaBarMinG = 0;
            int ManaBarMaxB = 30;
            int ManaBarMinB = 0;

            int WhiteTextMaxR = 255;
            int WhiteTextMinR = 100;
            int WhiteTextMaxG = 255;
            int WhiteTextMinG = 100;
            int WhiteTextMaxB = 255;
            int WhiteTextMinB = 100;

            List<VisionForm> TargetBar1 = new List<VisionForm>
            {
                /* Буква М */
                new VisionForm(){
                    OffsetX = 254, 
                    OffsetY = -6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                },


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
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 248, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 249, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },


                /* Полоса хп над маной */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },

            };



            /* Боссы с длинной полоской ХП */
            List<VisionForm> TargetBar2 = new List<VisionForm>
            {
                /* Буква М */
                new VisionForm(){
                    OffsetX = 365, 
                    OffsetY = -6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                },


                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 9, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 10, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 248, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 249, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },


                /* Полоса хп над маной */
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 9, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 10, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 250, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },

            };

            /* Маленькая полоска ХП */
            List<VisionForm> TargetBar3 = new List<VisionForm>
            {
                /* Буква М */
                new VisionForm(){
                    OffsetX = 153, 
                    OffsetY = -6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                },


                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 9, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 10, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 11, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 140, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 141, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 142, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },


                /* Полоса хп над маной */
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 6, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 7, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 8, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 9, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 10, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 11, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 12, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 16, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 32, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 64, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 128, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },
                new VisionForm(){
                    OffsetX = 141, 
                    OffsetY = 17, 
                    MaxR = ManaBarMaxR,
                    MinR = ManaBarMinR,
                    MaxG = ManaBarMaxG,
                    MinG = ManaBarMinG,
                    MaxB = ManaBarMaxB,
                    MinB = ManaBarMinB,
                },

            };



            VisionTarget.TargetBars.Add(TargetBar1);
            VisionTarget.TargetBars.Add(TargetBar2);
            VisionTarget.TargetBars.Add(TargetBar3);

        }
    }
}
