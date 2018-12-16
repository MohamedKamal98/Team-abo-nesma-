﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace food_Delivery_v_0._0
{
    class WinAPI
    {
        public const int HOR_Positive = 0X1;

        public const int HOR_NEGATIVE = 0X2;

        public const int VER_POSITIVE = 0X4;

        public const int VER_NEGATIVE = 0X8;

        public const int CENTER = 0X10;

        public const int BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
