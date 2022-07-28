using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }

    }
}
