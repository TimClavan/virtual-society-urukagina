﻿using System;

namespace Vs.VoorzieningenEnRegelingen.Core.Calc
{
    public static class CustomFunctions
    {
        public static TimeSpan Duration(DateTime begin, DateTime end)
        {
            return (begin - end);
        }

        public static TimeSpan Duration(TimeSpan begin, TimeSpan end)
        {
            return (begin - end);
        }

        public static double Percentage(double percentage)
        {
            return percentage / 100;
        }

        public static bool Niet(string value, string value2)
        {
            return !(value == value2);
        }

        public static bool Wel(string value, string value2) 
        {
            return (value == value2);
        }
    }
}
