using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Input a name: ");
            string input = Console.ReadLine();
            ValidateNames(input);

            Console.WriteLine("Input an email: ");
            string inputEmail = Console.ReadLine();
            ValidateEmail(inputEmail);

            Console.WriteLine("Input a phone number (xxxxxxxxxx or xxx-xxx-xxxx accepted: ");
            string inputPhone = Console.ReadLine();
            ValidatePhoneNumber(inputPhone);

            Console.WriteLine("Input a date (dd/mm/yyyy format): ");
            string inputDate = Console.ReadLine();
            ValidateDate(inputDate);
        }

        static void ValidateNames(string input)
        {
           if (Regex.IsMatch(input, @"^[a-zA-Z]+$") && Regex.IsMatch(input, @"^(?!^.{30}).+"))
            {
                Console.WriteLine($"Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void ValidateEmail(string inputEmail)
        {
            if (Regex.IsMatch(inputEmail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void ValidatePhoneNumber(string inputPhone)
        {
            
            if (Regex.IsMatch(inputPhone, @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void ValidateDate(string inputDate)
        {
            if (Regex.IsMatch(inputDate, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
