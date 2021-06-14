using System;
using Humanizer;

namespace SefirasHaOmer
{
    static class Program
    {
        public static string OmerPhrase(this int dayInOmer)
        {
            string omerDay = dayInOmer.ToWords();
            string omerWeek = (dayInOmer / 7).ToWords();
            string omerDayOfWeek = (dayInOmer % 7).ToWords();
            if (dayInOmer == 1) { return "TODAY IS ONE DAY OF THE OMER."; }
            if (dayInOmer < 7) { return $"TODAY IS {omerDay.ToUpper()} DAYS OF THE OMER."; }
            if (dayInOmer == 7) { return "TODAY IS SEVEN DAYS, WHICH ARE ONE WEEK OF THE OMER."; }
            if (dayInOmer == 8) { return "TODAY IS EIGHT DAYS, WHICH ARE ONE WEEK AND ONE DAY OF THE OMER."; }
            if (dayInOmer < 14) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE ONE WEEK AND {omerDayOfWeek.ToUpper()} DAYS OF THE OMER."; }
            if (dayInOmer % 7 == 0) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS OF THE OMER."; }
            if (dayInOmer % 7 == 1) { return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS OF THE OMER."; }
            return $"TODAY IS {omerDay.ToUpper()} DAYS, WHICH ARE {omerWeek.ToUpper()} WEEKS AND {omerDayOfWeek.ToUpper()} DAYS OF THE OMER.";

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
