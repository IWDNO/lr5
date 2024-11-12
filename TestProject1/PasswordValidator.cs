using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            // проверка длины
            if (password.Length < 8 || password.Length > 127) { return false; }
            // проверка Регистров
            if (!(password.Any(char.IsUpper) && password.Any(char.IsLower))) { return false; }
            //проверка на цифры
            if (!password.Any(char.IsDigit)) return false;
            //проверка на спец. символ
            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9\s]")) return false;
            //проверка на повторяющиеся символы
            if (Regex.IsMatch(password, @"(\S){3,}")) return false;

            return true;
        }
    }
}
