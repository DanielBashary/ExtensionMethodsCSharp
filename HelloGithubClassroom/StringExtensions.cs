using System;

namespace HelloGithubClassroom
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this String s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static string Reversed(this String s)
        {
            char[] word = s.ToCharArray();
            Array.Reverse(word);
            return new string(word);
        }
    }
}