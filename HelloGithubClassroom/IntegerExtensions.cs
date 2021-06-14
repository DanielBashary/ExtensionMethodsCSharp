using System;
using System.Linq;
using Humanizer;

namespace HelloGithubClassroom
{
    public static class IntegerExtensions
    {
        public static int Factorial(this int x)
        {
            int t = 1;
            for (int i = 1; i <= x; i++)
            {
                t *= i;
            }
            return t;
        }
        public static int Summation(this int x)
        {
            int s = 0;
            for (int i = 1; i <= x; i++)
            {
                s += i;
            }
            return s;
        }
        public static string EnglishSefirah(this int x)
        {
            string omerDay = x.ToWords();
            string omerWeek = (x / 7).ToWords();
            string omerDayOfWeek = (x % 7).ToWords();
            if (x == 1) { return "TODAY IS ONE DAY OF THE OMER."; }
            if (x < 7) { return $"TODAY IS {omerDay.ToUpper()} DAYS OF THE OMER."; }
            if (x == 7) { return "TODAY IS SEVEN DAYS, WHICH ARE ONE WEEK OF THE OMER."; }
            if (x == 8) { return "TODAY IS EIGHT DAYS, WHICH ARE ONE WEEK AND ONE DAY OF THE OMER."; }
            if (x < 14) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE ONE WEEK AND {omerDayOfWeek.ToUpper()} DAYS OF THE OMER."; }
            if (x % 7 == 0) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS OF THE OMER."; }
            if (x % 7 == 1) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS OF THE OMER."; }
            return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS AND {omerDayOfWeek.ToUpper()} DAYS OF THE OMER.";
        }
    }
}