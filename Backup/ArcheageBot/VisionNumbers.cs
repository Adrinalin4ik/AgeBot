using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionNumbers
    {
        public static List<List<VisionForm>> DistanceNumbers = new List<List<VisionForm>>();


        public static void LoadDistanceNumbers()
        {

            int WhiteTextMaxR = 255;
            int WhiteTextMinR = 210;
            int WhiteTextMaxG = 255;
            int WhiteTextMinG = 210;
            int WhiteTextMaxB = 255;
            int WhiteTextMinB = 210;

            int WhiteTextShadowMaxR = 120;
            int WhiteTextShadowMinR = 0;
            int WhiteTextShadowMaxG = 120;
            int WhiteTextShadowMinG = 0;
            int WhiteTextShadowMaxB = 120;
            int WhiteTextShadowMinB = 0;


            List<VisionForm> DistanceNumber0 = new List<VisionForm>
            {
                /* Цифра 0 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = -1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                
                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 6, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber1 = new List<VisionForm>
            {
                /* Цифра 1 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 3, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 5, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },

                /* Черный пиксель */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 7, 
                    MaxR = 25,
                    MinR = 0,
                    MaxG = 25,
                    MinG = 0,
                    MaxB = 25,
                    MinB = 0,
                    Object = true
                },

                /* Особый параметр - указываем кончик цифры 1 */
                
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 0, 
                    MaxR = 255,
                    MinR = 80,
                    MaxG = 255,
                    MinG = 80,
                    MaxB = 255,
                    MinB = 80,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 50,
                    MaxG = 255,
                    MinG = 50,
                    MaxB = 255,
                    MinB = 50,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 50,
                    MaxG = 255,
                    MinG = 50,
                    MaxB = 255,
                    MinB = 50,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber2 = new List<VisionForm>
            {
                /* Цифра 2 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                
                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber3 = new List<VisionForm>
            {
                /* Цифра 3 */
                
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = -1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -4, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 0, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },

                /* тень особого цвета */
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = 130,
                    MinR = 0,
                    MaxG = 130,
                    MinG = 0,
                    MaxB = 130,
                    MinB = 0,
                    Object = true
                },

                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 5, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },

                
                /* Особое условие для избежания конфликта с пятеркой */

                
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 3, 
                    MaxR = 255,
                    MinR = 50,
                    MaxG = 255,
                    MinG = 50,
                    MaxB = 255,
                    MinB = 50,
                    Object = true
                },


            };


            List<VisionForm> DistanceNumber4 = new List<VisionForm>
            {
                /* Цифра 4 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 3, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };





            List<VisionForm> DistanceNumber5 = new List<VisionForm>
            {
                /* Цифра 5 */
                
                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 3, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 5, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -3, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber6 = new List<VisionForm>
            {
                /* Цифра 6 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 3, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 6, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber7 = new List<VisionForm>
            {
                /* Цифра 7 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = 6, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 3, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },

                /* Особый верхний штрих */
                
                new VisionForm(){
                    OffsetX = -2, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = -1, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = 255,
                    MinR = 150,
                    MaxG = 255,
                    MinG = 150,
                    MaxB = 255,
                    MinB = 150,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber8 = new List<VisionForm>
            {
                /* Цифра 8 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 1, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 4, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 7, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistanceNumber9 = new List<VisionForm>
            {
                /* Цифра 9 */
                
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 0, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 2, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 3, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 4, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 3, 
                    OffsetY = 5, 
                    MaxR = WhiteTextMaxR,
                    MinR = WhiteTextMinR,
                    MaxG = WhiteTextMaxG,
                    MinG = WhiteTextMinG,
                    MaxB = WhiteTextMaxB,
                    MinB = WhiteTextMinB,
                    Object = true
                },

                /* Тень, для уточнения формы */
                new VisionForm(){
                    OffsetX = 2, 
                    OffsetY = 0, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 1, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 2, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 5, 
                    OffsetY = 5, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
                new VisionForm(){
                    OffsetX = 4, 
                    OffsetY = 6, 
                    MaxR = WhiteTextShadowMaxR,
                    MinR = WhiteTextShadowMinR,
                    MaxG = WhiteTextShadowMaxG,
                    MinG = WhiteTextShadowMinG,
                    MaxB = WhiteTextShadowMaxB,
                    MinB = WhiteTextShadowMinB,
                    Object = true
                },
            };


            List<VisionForm> DistancePointer = new List<VisionForm>
            {
                /* Точка–разделитель */
                
                /* Белая точка */
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 6, 
                    MaxR = 255,
                    MinR = 205,
                    MaxG = 255,
                    MinG = 205,
                    MaxB = 255,
                    MinB = 205,
                    Object = true
                },

                /* Cамая темная тень */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 7, 
                    MaxR = 45,
                    MinR = 0,
                    MaxG = 45,
                    MinG = 0,
                    MaxB = 45,
                    MinB = 0,
                    Object = true
                },

                // Слабая тень снизу от точки
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 7, 
                    MaxR = 145,
                    MinR = 20,
                    MaxG = 145,
                    MinG = 20,
                    MaxB = 145,
                    MinB = 20,
                    Object = true
                },

                // Слабая тень слева от точки 
                new VisionForm(){
                    OffsetX = -1, 
                    OffsetY = 6, 
                    MaxR = 245,
                    MinR = 125,
                    MaxG = 245,
                    MinG = 125,
                    MaxB = 245,
                    MinB = 125,
                    Object = true
                },


                /*
                // Слабая тень сверху от точки 
                new VisionForm(){
                    OffsetX = 0, 
                    OffsetY = 5, 
                    MaxR = 255,
                    MinR = 30,
                    MaxG = 255,
                    MinG = 30,
                    MaxB = 255,
                    MinB = 30,
                    Object = true
                },

                // Слабая тень справа от точки 
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 6, 
                    MaxR = 225,
                    MinR = 2,
                    MaxG = 225,
                    MinG = 2,
                    MaxB = 225,
                    MinB = 2,
                    Object = true
                },

                // Правый верхний угол - ограничиваем чтоб не путал с пятеркой 
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 5, 
                    MaxR = 245,
                    MinR = 0,
                    MaxG = 245,
                    MinG = 0,
                    MaxB = 245,
                    MinB = 0,
                    Object = true
                },
                
                */
            };

            VisionNumbers.DistanceNumbers.Add(DistanceNumber0);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber1);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber2);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber3);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber4);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber5);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber6);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber7);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber8);
            VisionNumbers.DistanceNumbers.Add(DistanceNumber9);
            VisionNumbers.DistanceNumbers.Add(DistancePointer);

        }


        public static double? GetDistance(int StartX, int y)
        {
            bool FindPointer = false;
            string number = "";

            for (int x = StartX; x < StartX + 35; x++)
            {
                int? CurrentNumber = VisionForm.FindForm(VisionNumbers.DistanceNumbers, x, y);
                if (CurrentNumber != null)
                {
                    if (CurrentNumber == 10)
                    {
                        if (FindPointer == false)
                        {
                            /* Дополнительная проверка на точку */
                            if (AdvancedPointCheck(x, y) == true)
                            {
                                FindPointer = true;
                                number = number + ",";
                            }
                        }
                    }
                    else
                    {
                        number = number + CurrentNumber.ToString();
                    }
                }
            }

            double Distance;
            try
            {
                Distance = Convert.ToDouble(number);
                return Distance;
            }
            catch (FormatException)
            {
                return null;
            }
            catch (OverflowException)
            {
                return null;
            }
            
        }

        public static bool AdvancedPointCheck(int x, int y)
        {
            long SummPointerColor = (ScreenCapture.LockBitmap.Screen.GetPixel(x, y + 6).R + ScreenCapture.LockBitmap.Screen.GetPixel(x, y + 6).G + ScreenCapture.LockBitmap.Screen.GetPixel(x, y + 6).B);

            /* Смотрим что сверху */
            for (int TestSpaceY = y - 3; TestSpaceY <= y + 4; ++TestSpaceY)
            {
                for (int TestSpaceX = x - 1; TestSpaceX <= x + 1; ++TestSpaceX)
                {
                    long SummCurrentPixel = ScreenCapture.LockBitmap.Screen.GetPixel(TestSpaceX, TestSpaceY).R + ScreenCapture.LockBitmap.Screen.GetPixel(TestSpaceX, TestSpaceY).G + ScreenCapture.LockBitmap.Screen.GetPixel(TestSpaceX, TestSpaceY).B;

                    if ((SummPointerColor - 1) < SummCurrentPixel)
                    {
                        return false;
                    }
                }
            }

            /* Смотрим на соседний правый пиксель */
            long RightPixel = ScreenCapture.LockBitmap.Screen.GetPixel(x + 1, y + 6).R + ScreenCapture.LockBitmap.Screen.GetPixel(x + 1, y + 6).G + ScreenCapture.LockBitmap.Screen.GetPixel(x + 1, y + 6).B;
            if ((SummPointerColor - 100) < RightPixel)
            {
                return false;
            }


            return true;
        }
    }
}
