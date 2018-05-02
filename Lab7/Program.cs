using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string input1 = Console.ReadLine();
            CheckName(input1);

            Console.WriteLine("please enter your phone number");
            string input2 = Console.ReadLine();
            CheckPhone(input2);

            Console.WriteLine(" please enter your email");
            string input3 = Console.ReadLine();
            CheckEmail(input3);

            Console.WriteLine("please enter todays date");
            string input4 = Console.ReadLine();
            CheckDate(input4);
        }

        public static void CheckName(string input1)
        {
            while (!Regex.IsMatch(input1, "^[A-Za-z '-]{2,30}$"))
            {
                Console.WriteLine("This is not a valid name.");
                Console.WriteLine("please enter your name");
                input1 = Console.ReadLine();
            }
            Console.WriteLine("thanks, now I know your name");           
        }
        public static void CheckPhone(string input2)
        {
            while (!Regex.IsMatch(input2, "^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                Console.WriteLine("This is not a valid phone number");
                Console.WriteLine("please enter your phone number with the format; ###-###-####");
                input2 = Console.ReadLine();
            }
            Console.WriteLine("thanks, now I know your phone number");
        }
        public static void CheckEmail(string input3)
        {
            while (!Regex.IsMatch(input3, @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"))
            {
                Console.WriteLine("This is not a valid email");
                Console.WriteLine("please enter your email");
                input3 = Console.ReadLine();
            }
            Console.WriteLine("thanks, now I have your email");
        }
        public static void CheckDate(string input4)
        {
            while(!Regex.IsMatch(input4, @"^(0[1-9]|1[012])[-/.](0[1-9] |[12][0-9]|3[01])[-/.](19|20)\d\d$"))
            {
                
                Console.WriteLine("That is not a valid format for todays date please use the format mm/dd/yyyy");
                Console.WriteLine("please enter todays date");
                input4 = Console.ReadLine();
            }
            Console.WriteLine("thank you for remininding me of todays date");       
        }
    }
    
}
