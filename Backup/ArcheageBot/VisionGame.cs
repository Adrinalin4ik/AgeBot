using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionGame
    {
        public static List<List<VisionForm>> ButtonF = new List<List<VisionForm>>();
        public static List<List<VisionForm>> ButtonG = new List<List<VisionForm>>();

        public static void LoadButtonG()
        {

            int YellowTextMaxR = 245;
            int YellowTextMinR = 135;
            int YellowTextMaxG = 160;
            int YellowTextMinG = 80;
            int YellowTextMaxB = 55;
            int YellowTextMinB = 20;

            int YellowTextShadowMaxR = 30;
            int YellowTextShadowMinR = 0;
            int YellowTextShadowMaxG = 30;
            int YellowTextShadowMinG = 0;
            int YellowTextShadowMaxB = 30;
            int YellowTextShadowMinB = 0;

            List<VisionForm> PickButtonG1 = new List<VisionForm>
            {
                /* Форма буквы G */
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 1, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 2, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },

                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 5, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 7, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 7, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                /* Тень для уточнения формы буквы */
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 0, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = -5, 
                    OffsetY = 3, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = -5, 
                    OffsetY = 4, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 8, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 5, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 6, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                
                
                
                
                
            };

            VisionGame.ButtonG.Add(PickButtonG1);

        }

        public static void LoadButtonF()
        {

            int YellowTextMaxR = 245;
            int YellowTextMinR = 135;
            int YellowTextMaxG = 160;
            int YellowTextMinG = 80;
            int YellowTextMaxB = 55;
            int YellowTextMinB = 20;

            int YellowTextShadowMaxR = 30;
            int YellowTextShadowMinR = 0;
            int YellowTextShadowMaxG = 30;
            int YellowTextShadowMinG = 0;
            int YellowTextShadowMaxB = 30;
            int YellowTextShadowMinB = 0;

            List<VisionForm> PickButtonF1 = new List<VisionForm>
            {
                /* Форма буквы F */
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 3, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 6, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 7, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 3, 
                    MaxR = YellowTextMaxR,
                    MinR = YellowTextMinR,
                    MaxG = YellowTextMaxG,
                    MinG = YellowTextMinG,
                    MaxB = YellowTextMaxB,
                    MinB = YellowTextMinB,
                    Object = true
                },

                
                /* Тень для уточнения формы буквы */
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -1, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -1, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = -1, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 2, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 8, 
                    MaxR = YellowTextShadowMaxR,
                    MinR = YellowTextShadowMinR,
                    MaxG = YellowTextShadowMaxG,
                    MinG = YellowTextShadowMinG,
                    MaxB = YellowTextShadowMaxB,
                    MinB = YellowTextShadowMinB,
                },
            };

            VisionGame.ButtonF.Add(PickButtonF1);

        }
    }
}
