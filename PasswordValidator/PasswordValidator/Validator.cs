using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class Validator
    {
        //-----------------------------------------------------------------------------------------------------Iteration 1
        //public static bool Validate(string pw)
        //{
        //    return true;
        //}

        //-----------------------------------------------------------------------------------------------------Iteration 2
        //public static bool Validate(string pw)
        //{
        //    return pw.Length > 5;
        //}

        //-----------------------------------------------------------------------------------------------------Iteration 3
        //public static bool Validate(string pw)
        //{
        //    if (pw.Length > 5 && pw.Any(char.IsUpper))
        //        return true;
        //    else
        //        return false;
        //}

        //-----------------------------------------------------------------------------------------------------Iteration 4
        //public static bool Validate(string pw)
        //{
        //    if (pw.Length > 5 && pw.Any(char.IsUpper) && pw.Any(char.IsNumber))
        //        return true;
        //    else
        //        return false;
        //}

        //-----------------------------------------------------------------------------------------------------Iteration 5

        //Minimum 6 characters, at least one uppercase letter, one lowercase letter and one number:
        //private static string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$";

        //public static bool Validate(string pw)
        //{
        //    return Regex.Match(pw, pattern).Success;
        //}
    }
}
