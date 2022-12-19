using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCanProveAnything
{
    public class StringHelper
    {
        public static string GenerateCharacterLine(char character, int count)
        {
            if (count <= 0) return "";
            
            string line = "";
            for (int i = 0; i <= count; i++)
            {
                line += character;
            }
            return line;
        }

        public static string CenterText(string text, int totalLength)
        {
            if (totalLength <= text.Length) return text;

            // Als verschil oneven is, dan achteraan 1 spatie minder.
            int spaces = totalLength - text.Length / 2;

            for (int i = 0; i < spaces; i++)
            {
                text = " " + text + " ";
            }

            if (text.Length < totalLength)
            {
                text = " " + text;
            }

            return text;
        }
    }
}
