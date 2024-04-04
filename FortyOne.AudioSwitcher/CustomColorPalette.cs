using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FortyOne.AudioSwitcher
{
    public static class CustomColorPalette 
    {
        private static ColorConverter colorConverter = new ColorConverter();

         
        public static Color Electromagnetic = (Color)colorConverter.ConvertFromString("#2f3640");
        public static Color BlueNights = (Color)colorConverter.ConvertFromString("#353b48");
        public static Color BlackPearl = (Color)colorConverter.ConvertFromString("#1e272e");

    }
}
