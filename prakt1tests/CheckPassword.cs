using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword
{
    public class CheckPassword
    {
        public static int ValidatePassword(string password)
        {
            int score = 0;

            if (password.Length > 10)
            {
                score++;
            }

            if (password.Any(char.IsDigit))
            {
                score++;
            }

            if (password.Any(char.IsLower))
            {
                score++;
            }

            if (password.Any(char.IsUpper))
            {
                score++;
            }

            if (password.Any(c => !char.IsLetterOrDigit(c)))
            {
                score++;
            }

            return score;
        }
    }
}
