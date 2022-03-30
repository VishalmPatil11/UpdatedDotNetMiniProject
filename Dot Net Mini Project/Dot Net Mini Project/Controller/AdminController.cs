using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Mini_Project.Controller
{
    class AdminController
    {

        public static void FetchUsers()
        {
            MyDbContext myDbContext = new MyDbContext();
            User user = new User();
            Console.WriteLine("UserId | UserName | Email | Password | Department");
            foreach (var item in myDbContext.users)
            {
                Console.WriteLine(item.UserId + "   " + item.UserName + "   " + item.Email + "      " + item.Password + "      " + item.Department);
            }
        }

        public static void AddUser()
        {
            MyDbContext myDbContext = new MyDbContext();
            User user = new User();

            Console.Write("Please Enter the userName: ");
            user.UserName = Console.ReadLine();

            Console.Write("Please Enter the email: ");
            user.Email = Console.ReadLine();

            Console.Write("Please Enter the Password: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            user.Password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Department: ");
            user.Department = Console.ReadLine();

            myDbContext.users.Add(user);
            myDbContext.SaveChanges();

            Console.WriteLine("User added sucessfully");

        }

        public static void RemoveUser()
        {
            MyDbContext myDbContext = new MyDbContext();
            User user = new User();

            Console.Write("Enter userId: ");
            user.UserId = Convert.ToInt32(Console.ReadLine());

            var removeUserData = myDbContext.users.First(x => x.UserId == user.UserId);

            myDbContext.users.Remove(removeUserData);

            //Console.ForegroundColor = ConsoleColor.White;

            myDbContext.users.Remove(user);
            myDbContext.SaveChanges();

            Console.WriteLine("User removed sucessfully");

        }

        public static void AddProduct()
        {
            MyDbContext myDbContext = new MyDbContext();
            Iphone iphone = new Iphone();

            Console.Write("Please Enter the productName: ");
            iphone.ProductName = Console.ReadLine();

            Console.Write("Please Enter the Quantity: ");
            //Console.ForegroundColor = ConsoleColor.Black;
            iphone.Quantity = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Please Enter Price: ");
            iphone.Price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please Enter the UserId: ");
            iphone.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the category: ");
            iphone.Category = Console.ReadLine();

            myDbContext.iphones.Add(iphone);
            myDbContext.SaveChanges();

            Console.WriteLine("Product added sucessfully");
        }

        public static void FetchProductData()
        {
            MyDbContext myDbContext = new MyDbContext();
            Iphone iphone = new Iphone();
            Console.WriteLine("ProductName | Quantity | Price");
            foreach (var item in myDbContext.iphones)
            {
                Console.WriteLine(item.ProductName + "   " + item.Quantity + "      " + item.Price);
            }
        }

        public static void UpdateProduct()
        {
            Console.WriteLine("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Updated Price: ");
            int priceUpdated = Convert.ToInt32(Console.ReadLine());

            MyDbContext myDbContext = new MyDbContext();

            Iphone iphone = myDbContext.iphones.Find(id);
            iphone.Price = priceUpdated;
            myDbContext.iphones.Update(iphone);

            Console.WriteLine(myDbContext.SaveChanges());

            Console.WriteLine("Product updated sucessfully");
        }

        public static void RemoveProduct()
        {
            MyDbContext myDbContext = new MyDbContext();
            Iphone iphone = new Iphone();
            Console.Write("Enter ProductName: ");
            iphone.ProductName = Console.ReadLine();

            Console.Write("Please Enter the UserId: ");
            iphone.UserId = Convert.ToInt32(Console.ReadLine());


            var removeProductData = myDbContext.iphones.First(x => x.ProductName == iphone.ProductName);

            myDbContext.iphones.Remove(removeProductData);

            //Console.ForegroundColor = ConsoleColor.White;

            myDbContext.iphones.Remove(removeProductData);
            myDbContext.SaveChanges();

            Console.WriteLine("product removed sucessfully");

        }

    }
}
