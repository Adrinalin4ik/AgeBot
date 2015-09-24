using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class Keyboard
    {
        ///summary>
        /// Virtual Messages
        /// </summary>
        public enum WMessages : int
        {
            WM_LBUTTONDOWN = 0x201, //Left mousebutton down
            WM_LBUTTONUP = 0x202,  //Left mousebutton up
            WM_LBUTTONDBLCLK = 0x203, //Left mousebutton doubleclick
            WM_RBUTTONDOWN = 0x204, //Right mousebutton down
            WM_RBUTTONUP = 0x205,   //Right mousebutton up
            WM_RBUTTONDBLCLK = 0x206, //Right mousebutton doubleclick
            WM_KEYDOWN = 0x100,  //Key down
            WM_KEYUP = 0x101,   //Key up
            WM_CHAR = 0x0102,
            VK_RETURN = 0x0D,
        }
    }
}
