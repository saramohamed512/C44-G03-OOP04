using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04
{
    internal class Duration
    {
        #region Attributes 
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region overrides 

        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0)
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";

            return result;
        }

    
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }
        #endregion
        #region Constructors
        private void FromTotalSeconds(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            int remaining = totalSeconds % 3600;
            Minutes = remaining / 60;
            Seconds = remaining % 60;
        }
        private void NormalizeTime(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            FromTotalSeconds(totalSeconds);
        }
    
        public Duration(int hours, int minutes, int seconds)
        {
            NormalizeTime(hours, minutes, seconds);
        }

      
        public Duration(int totalSeconds)
        {
            FromTotalSeconds(totalSeconds);
        }
        #endregion
        #region Operator overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds +
                              d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds;
            return new Duration(totalSeconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) -
                               (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(Math.Abs(totalSeconds));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <=
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >=
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        // True if duration is not zero
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        // False if duration is zero
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        // Explicit conversion to DateTime
        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Now.AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }
        #endregion

    }
}
