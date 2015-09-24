using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ArcheageBot
{
    class VisionForm
    {
        public int OffsetX;
        public int OffsetY;
        public int MaxR;
        public int MinR;
        public int MaxG;
        public int MinG;
        public int MaxB;
        public int MinB;
        public int AlternateMaxR = -1;
        public int AlternateMinR = -1;
        public int AlternateMaxG = -1;
        public int AlternateMinG = -1;
        public int AlternateMaxB = -1;
        public int AlternateMinB = -1;
        public bool Object = false;
        public List<string> Description;

        public static int? FindForm(List<List<VisionForm>> Forms, int StartX, int StartY)
        {
            bool ErrorFindPixel;
            Color CurrentColor;

            for (int CurrentFormCount = 0; CurrentFormCount < Forms.Count; ++CurrentFormCount)
            {
                ErrorFindPixel = false;

                for (int i = 0; i < Forms[CurrentFormCount].Count; ++i)
                {
                    CurrentColor = ScreenCapture.LockBitmap.Screen.GetPixel(StartX + Forms[CurrentFormCount][i].OffsetX, StartY + Forms[CurrentFormCount][i].OffsetY);

                    if (
                            ((CurrentColor.R >= Forms[CurrentFormCount][i].MinR) && (CurrentColor.R <= Forms[CurrentFormCount][i].MaxR)) &&
                            ((CurrentColor.G >= Forms[CurrentFormCount][i].MinG) && (CurrentColor.G <= Forms[CurrentFormCount][i].MaxG)) &&
                            ((CurrentColor.B >= Forms[CurrentFormCount][i].MinB) && (CurrentColor.B <= Forms[CurrentFormCount][i].MaxB))
                    )
                    {
                        /* пиксель удовлетворяет условиям — идем дальше */
                    }
                    else if (
                            ((CurrentColor.R >= Forms[CurrentFormCount][i].AlternateMinR) && (CurrentColor.R <= Forms[CurrentFormCount][i].AlternateMaxR)) &&
                            ((CurrentColor.G >= Forms[CurrentFormCount][i].AlternateMinG) && (CurrentColor.G <= Forms[CurrentFormCount][i].AlternateMaxG)) &&
                            ((CurrentColor.B >= Forms[CurrentFormCount][i].AlternateMinB) && (CurrentColor.B <= Forms[CurrentFormCount][i].AlternateMaxB))
                    )
                    {
                        /* альтернативный цвет пикселя удовлетворяет условиям — идем дальше */
                    }
                    else
                    {
                        ErrorFindPixel = true;
                        break;
                    }
                }

                if (ErrorFindPixel == false)
                {
                    /* Если поиск формы не содержал ошибок - возвращяем значение */
                    return CurrentFormCount;
                }
            }

            /* все формы не прошли условия */
            return null;
        }
    }
}
