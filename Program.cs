using System;

namespace Regax
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone;
            bool result;

            ValidatePhoneNumber validatePhoneNumber = new ValidatePhoneNumber();

            Console.WriteLine("Enter the Pin code");

            phone = Console.ReadLine();

            result = validatePhoneNumber.PhoneNumberCheck(phone);

            Console.WriteLine(result);

        }
    }
}
