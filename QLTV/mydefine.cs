﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class mydefine
    {
        //Datasourse (khac nhau)
        public const string dataSource = @"Data Source=DESKTOP-3PP3KKO;Initial Catalog=QLTV;Integrated Security=True";
        public static int Clamp(ref int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;

        }
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);

    }

}
