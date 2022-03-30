using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class LoginController
    {
        public static void Login()
        {
            MyDbContext myDbContext = new MyDbContext();
            Console.Write("Enter userName: ");
            var userName = Console.ReadLine().ToLower();


            Console.Write("Enter password: ");
            var password = Console.ReadLine().ToLower();

            bool isFound = false;

            foreach (User user in myDbContext.users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    isFound = true;
                    Console.WriteLine("Login successful");
                }

            }

            if (isFound == false)
            {
                Console.WriteLine("Invalid credentials");
            }
        }
    }
}
