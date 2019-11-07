using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wellcome message
            Console.WriteLine(">>>>The Holiday Park new Login System<<<<");
            Console.WriteLine("****Welcome to the Rotorua Thermal Holiday Park****");
            Console.WriteLine();

            //ask the user for name and password
            string result = "";
            string result2 = "";

            do
            {


                Console.WriteLine("Please enter your name that must be 8 characters long");
                string username = Console.ReadLine();
                Console.WriteLine($"{ ValidateUsername(username)}");
                result = ValidateUsername(username);
            }
            while (result != "Your username is correct");

            do
            {
                Console.WriteLine("please enter your password that must be 8 character long");
                string password = Console.ReadLine();
                Console.WriteLine("Please re-enter your password");
                string password2 = Console.ReadLine();
                Console.WriteLine($"{ ValidatePassword(password, password2)}");
                result2 = ValidatePassword(password, password2);

            }
            while (result2 != "Your password is correct");
            Console.WriteLine("****Username and Password have been accepted and set****");
            Console.ReadLine();


        }

        //ValidateUsername method for 8 characters username
        static string ValidateUsername(string username)
        {
            string result;
            if (username.Length >= 8)

            { result = "Your username is correct"; }

            else

            { result = "Invalid username"; }
            return result;


        }

        //ValidatePassword method for 8 characters password

        static string ValidatePassword(string password, string password2)
        {
            string result2;
            if (password.Length >= 8)
            {
                if (password == password2)
                { result2 = "Your password is correct"; }
                else { result2 = "Sorry your password does not match"; }
            }
            else
            {
                result2 = "Invalid password";
            }
            return result2;

        }
    }
}
        
    

