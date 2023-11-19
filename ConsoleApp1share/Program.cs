namespace ConsoleApp1share
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Inventory Management System!");



            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            // Check if the username is "verified" or not 
            string verificationStatus = ((username.ToLower() == "admin") && (password.ToLower() == "adminpass")) ? $"Authentication successful! Welcome, {username} !" : "not verified, Try agin..";
            Console.WriteLine(verificationStatus);

            Console.WriteLine(
                   "\n1.  Add a new product.\n" +
                   "2.  Update product quantity \n" +
                   "3. Display product list \n" +
                   "4. Record sale \n" +
                   "5. Generate product report\n" +
                   "6.Generate sales report \n" +
                   "7. Exit \n"
               );
            string productName;
            int price;
            int quantity;
            int quantitySold;

            Console.Write("Select an operation (1-7): ");
            int choise = Convert.ToInt32(Console.ReadLine());

            //array////
            switch (choise)
            {

                case 1:
                    Console.Write("Enter product name: ");
                    productName = Console.ReadLine();

                    Console.Write("Enter product price: ");
                    price = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter initial quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Product added successfully!");

                    break;
                case 2:
                    
                    int updateQ = (quantity - quantitySold);
                    Console.WriteLine("new product Quantity is :" + updateQ);

                     break;
                case 3:
                    Console.WriteLine("Product List :");
                    Console.WriteLine($"{productName},{price},{quantity}");




                    break;
                case 4:
                    Console.WriteLine("Enter Product Name : ");
                    productName = Console.ReadLine();
                    Console.WriteLine("Enter quantity sold : ");
                    quantitySold = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sale recorded successfully!");
                    
                    break;
                case 5:
                    Console.WriteLine("product Report: ");
                    break;
                case 6:
                    Console.WriteLine("Sales Report: ");
                    Console.WriteLine("Total Sales: ");
                    Console.WriteLine("Total Revenue: ");
                    break;
                case 7:
                    Console.WriteLine("Thank you for using the Inventory Management System, admin!");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }



        }
    }
}