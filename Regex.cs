using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regax
{
    class ValidatePhoneNumber
    {
        public string Regexpatteren = "^[1-9]{1}[1-5]{1}$";



        public bool PhoneNumberCheck(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, Regexpatteren);
        }
    }
}

