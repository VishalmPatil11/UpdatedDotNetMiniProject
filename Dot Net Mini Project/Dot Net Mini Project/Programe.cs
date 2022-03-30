using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;
using Dot_Net_Mini_Project.Controller;



namespace Dot_Net_Mini_Project
{
    class Programe
    {

        static void Main(string[] args)
        {
            MyDbContext myDbContext = new MyDbContext();
            bool flag = true;
            User user = new User();
            Iphone iphone = new Iphone();
            Ipad ipad = new Ipad();
            

            //do
            while (flag)
            {
                Console.WriteLine("Welcome To Inventory Management System");

                var ctx = new MyDbContext();
                //Controller myController = new Controller();
                //User user = new User() { UserName = "vishal", Email = "vishalmil@cyb.com", Password = "1234", Department = "Admin" };
                //ctx.users.Add(user);
                //Console.WriteLine(ctx.SaveChanges());

                Console.WriteLine("Enter Choice: ");
                Console.WriteLine("1:Admin\n2:User\n3:Exit");

                var choice = Convert.ToInt32(Console.ReadLine());



                switch (choice)
                {
                    case 1:

                        if (choice == 1)
                        {
                            LoginController.Login();

                            bool flag1 = true;
                            //do
                            while(flag1)
                            {
                                Console.WriteLine("1:Fetch User\n2:Add User\n3:Remove User\n4:Fetch Product Data\n5:Add Product \n6:Update Product Data \n7: Remove Product \n8:Exit");

                                var choices = Convert.ToInt32(Console.ReadLine());

                                switch (choices)
                                {
                                    case 1:
                                        AdminController.FetchUsers();                                        
                                        break;
                                    case 2:
                                        AdminController.AddUser();
                                        
                                        break;
                                    case 3:
                                        AdminController.RemoveUser();
                                        break;
                                    case 4:
                                        AdminController.FetchProductData();
                                        break;
                                    case 5:
                                        AdminController.AddProduct();
                                        break;
                                    case 6:
                                        AdminController.UpdateProduct();
                                        break;
                                    case 7:
                                        AdminController.RemoveProduct();
                                        break;                                   
                                    case 8:
                                        Console.WriteLine("Exited Sucessfully!");
                                        break;
                                    default:
                                        flag1 = false;
                                        break;
                                }
                            } //while (flag1);

                        }
                       

                        else Console.WriteLine("Please give right options");


                        break;
                    case 2:
                        if(choice == 2)

                            LoginController.Login();

                        //do
                        bool flag2 = true;
                        while (flag2)
                        {
                            
                            Console.WriteLine("1:Fetch Product\n2:Add Product\n3:Update Product\n4:Remove Product\n5:Exit");
                            var choice2 = Convert.ToInt32(Console.ReadLine());
                            
                            Console.WriteLine(user.UserId);
                            Console.WriteLine("Enter your id: ");
                            var uId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter your category: ");
                            var uCategory = Console.ReadLine();
                            

                            switch (choice2)
                            {
                                case 1:            
                                    
                                    if (user.UserId == uId && iphone.Category == uCategory)
                                    {
                                        IphoneController.FetchProductData();
                                    }else if(user.UserId == uId && ipad.Category == uCategory)
                                    {
                                        IpadController.FetchProductData();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid");
                                    }
                                    break;
                                case 2:
                                    IpadController.AddProduct();
                                    break;
                                case 3:
                                    AdminController.UpdateProduct();
                                    break;
                                case 4:
                                    IphoneController.RemoveProduct();
                                    break;
                                case 5:
                                    Console.WriteLine("Exited Successfully...");
                                    break;
                                default:
                                    flag2 = false;
                                    break;
                            }
                        } //while (flag2);
                        break;
                    case 3:
                        Console.WriteLine("Exited Successfully...");
                        break;
                    default:
                        flag = false;
                        break;
                }
            } //while (flag);
        }
    }
}