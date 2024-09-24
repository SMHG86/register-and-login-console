using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace porojee
{
    internal class pass
    {
        public static int CalculatePasswordStrength(string password)
        {
            int score = 0;

            // حداقل طول
            if (password.Length >= 5) score++;

            // وجود اعداد
            if (Regex.IsMatch(password, @"\d")) score++;

            // وجود حروف بزرگ و کوچک
            if (Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[A-Z]")) score++;

            // وجود کاراکترهای خاص
            if (Regex.IsMatch(password, @"[@#]")) score++;

            return score;
        }
    }
}
