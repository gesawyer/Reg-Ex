using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string pattern = (@"\b([A-Z][-,a-z. ']+[ ]*)+");
                string name = ("Sarita");

                if (Regex.IsMatch(name, pattern))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

                string email = ("graceseymore1@gmail.com");
                string emailPattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (Regex.IsMatch(email, emailPattern))
                {
                    Console.WriteLine("Email is valid!");
                }
                else
                {
                    Console.WriteLine("Email is not valid!");
                }

                string phone = ("248-835-3472");
                string phonePattern = (@"\d\d\d-\d\d\d-\d\d\d\d");
                if (Regex.IsMatch(phone, phonePattern))
                {
                    Console.WriteLine("Phone number is valid!");
                }
                else
                {
                    Console.WriteLine("That's not how you write a phone number!");
                }

                string date = ("07/01/2020");
                string datePattern = (@"\d\d/\d\d/\d\d\d\d");
                if (Regex.IsMatch(date, datePattern))
                {
                    Console.WriteLine("Date entered is valid!");
                }
                else
                {
                    Console.WriteLine("invalid date entered");
                }

            }

        }    

    }       
            
           
}


   

