//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Data.SqlClient;
//using System.Linq;


//namespace Dot_Net_Mini_Project
//{
//     class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome To Inventory Management System");

//            var ctx = new MyDbContext();
//            //User user = new User() { UserName="vishal", Email="vishalmil@cyb.com",Password="1234",Department="Admin" };
//            //ctx.users.Add(user);
//            //Console.WriteLine(ctx.SaveChanges());

//            Console.WriteLine("Enter Choice: ");
//            Console.WriteLine("1:Admin\n2:User\n3:Exit");
            
//            var choice = Convert.ToInt32(Console.ReadLine());

            

//            switch (choice)
//            {
//                case 1:
                    
//                    if (choice == 1)
//                    {

//                        Login();


//                    }
//                    //else if (opt == 2) registration();

//                    else Console.WriteLine("Please give right options");

//                    Console.WriteLine("1:Add User\n2:Remove User\n3:Fetch Product Data\n4:Add Product \n5:Update Product Data \n6: Delete Product \n7:Exit");

//                    var choices = Convert.ToInt32(Console.ReadLine());

//                    switch (choices)
//                    {
//                        case 1:
//                            AddUser();
//                            break;
//                        case 2:
//                            RemoveUser();
//                            break;
//                        case 3:
//                            Console.WriteLine("Exited Successfully...");
//                            break;
//                    }
//                    break;
//                case 2:
//                    //if (choice == 2)
//                    //{
                       
//                        Login();


//                    //}
//                    ////else if (opt == 2) registration();

//                    //else Console.WriteLine("Please give right options");

//                    Console.WriteLine("1:Fetch Product\n2:Add Product\n3:Update Product\n4:Remove Product\n5:Exit");
//                    var choice2 = Convert.ToInt32(Console.ReadLine());

//                    switch (choice2)
//                    {
//                        case 1:
//                            FetchProductData();
//                            break;
//                        case 2:
//                            AddProduct();
//                            break;
//                        case 3:
//                            UpdateProduct();
//                            break;
//                        case 4:
//                            RemoveProduct();
//                            break;
//                        case 5:
//                            Console.WriteLine("Exited Successfully...");
//                            break;
//                    }
//                    break;
//                case 3:
//                    Console.WriteLine("Exited Successfully...");
//                    break;
//            }
//        }
//        public static void Login()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            Console.Write("Enter userName: ");
//            var userName = Console.ReadLine();

//            Console.Write("Enter password: ");
//            var password = Console.ReadLine();

//            SqlParameter p1 = new SqlParameter();
//            SqlParameter p2 = new SqlParameter();

//            p1.ParameterName = "@userName";
//            p1.Value = userName;
//            p1.SqlDbType = System.Data.SqlDbType.VarChar;
//            p2.ParameterName = "@password";
//            p2.Value = password;
//            p2.SqlDbType = System.Data.SqlDbType.VarChar;
//            // var user = (User)stuDb1.Users.FromSqlRaw("select * from UserTable where Email_ID = @Email_Id ");
//            var users = myDbContext.users.ToList();
//            User user = new User();
//            foreach (User user1 in users)
//            {
//                if (user1.UserName == userName && user1.Password == password) user = user1;
//                {
//                    Console.WriteLine("Login Successfully");
//                }
//                //else Console.WriteLine("User Not Found");
//            }

//        }

//        public static void AddUser()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            User user = new User();

//            Console.Write("Please Enter the userName: ");
//            user.UserName = Console.ReadLine();

//            Console.Write("Please Enter the email: ");
//            user.Email = Console.ReadLine();

//            Console.Write("Please Enter the Password: ");
//            //Console.ForegroundColor = ConsoleColor.Black;
//            user.Password = Console.ReadLine();
//            Console.ForegroundColor = ConsoleColor.White;

//            Console.Write("Please Enter Department: ");
//            user.Department = Console.ReadLine();
    
//            myDbContext.users.Add(user);
//            myDbContext.SaveChanges();

//            Console.WriteLine("User added sucessfully");

//            }

//        public static void RemoveUser()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            User user = new User();

//            Console.Write("Enter userId: ");
//            user.UserId = Convert.ToInt32(Console.ReadLine());

//            var removeUserData = myDbContext.users.First(x => x.UserId == user.UserId);

//            myDbContext.users.Remove(removeUserData);

//            //Console.ForegroundColor = ConsoleColor.White;

//            myDbContext.users.Remove(user);
//            myDbContext.SaveChanges();

//            Console.WriteLine("User removed sucessfully");

//        }

//        public static void AddProduct()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            Iphone iphone = new Iphone();

//            Console.Write("Please Enter the productName: ");
//            iphone.ProductName = Console.ReadLine();

//            Console.Write("Please Enter the category: ");
//            iphone.Category = Console.ReadLine();

//            Console.Write("Please Enter the Quantity: ");
//            //Console.ForegroundColor = ConsoleColor.Black;
//            iphone.Quantity = Convert.ToInt32(Console.ReadLine());
//            //Console.ForegroundColor = ConsoleColor.White;

//            Console.Write("Please Enter Price: ");
//            iphone.Price = Convert.ToDecimal(Console.ReadLine());

//            Console.Write("Please Enter the UserId: ");
//            iphone.UserId = Convert.ToInt32(Console.ReadLine());

//            myDbContext.iphones.Add(iphone);
//            myDbContext.SaveChanges();

//            Console.WriteLine("Product added sucessfully");
//        }

//        public static void FetchProductData()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            Iphone iphone = new Iphone();

//            Console.Write("Please Enter the category: ");
//            iphone.Category = Console.ReadLine();
//            Console.WriteLine("ProductName|Quantity|Price");
//            foreach (var item in myDbContext.iphones)
//            {
//                Console.WriteLine(item.ProductName+"   "+item.Quantity+"      "+item.Price);
//            }



//            //myDbContext.iphones.Add(iphone);
//            //myDbContext.SaveChanges();

//            //Console.WriteLine("Product added sucessfully");
//        }

//        public static void UpdateProduct()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            Iphone iphone = new Iphone();
//            Console.Write("Enter ProductName: ");
//            iphone.ProductName = Console.ReadLine();

//            var updateIphoneData = myDbContext.iphones.First(x => x.ProductName == iphone.ProductName);

//            Console.Write("Please Enter the productName: ");
//            iphone.ProductName = Console.ReadLine();

//            Console.Write("Please Enter the Quantity: ");
//            //Console.ForegroundColor = ConsoleColor.Black;
//            iphone.Quantity = Convert.ToInt32(Console.ReadLine());
//            //Console.ForegroundColor = ConsoleColor.White;

//            Console.Write("Please Enter Price: ");
//            iphone.Price = Convert.ToDecimal(Console.ReadLine());
//            //foreach (var item in ciphone)
//            //{
//            //    Console.Write(iphone.ProductName);
//            //}
//            Console.Write("Please Enter the UserId: ");
//            iphone.UserId = Convert.ToInt32(Console.ReadLine());



//            myDbContext.iphones.Update(updateIphoneData);
//            Console.WriteLine( myDbContext.SaveChanges());

//            Console.WriteLine("Product updated sucessfully");
//        }

//        public static void RemoveProduct()
//        {
//            MyDbContext myDbContext = new MyDbContext();
//            Iphone iphone = new Iphone();
//            Console.Write("Enter ProductName: ");
//            iphone.ProductName = Console.ReadLine();

//            Console.Write("Please Enter the UserId: ");
//            iphone.UserId = Convert.ToInt32(Console.ReadLine());


//            var removeProductData = myDbContext.iphones.First(x => x.ProductName == iphone.ProductName);

//            myDbContext.iphones.Remove(removeProductData);

//            //Console.ForegroundColor = ConsoleColor.White;

//            myDbContext.iphones.Remove(removeProductData);
//            myDbContext.SaveChanges();

//            Console.WriteLine("product removed sucessfully");

//        }


//    }
//}


////}
