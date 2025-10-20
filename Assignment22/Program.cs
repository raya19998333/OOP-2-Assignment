using Assignment22.Models.Animal;
using Assignment22.Models.BankAccount;
using Assignment22.Models.Book;
using Assignment22.Models.IDevice;
using Assignment22.Models.Product;
using Assignment22.Models.Student;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book
            // Creating book objects
            Console.WriteLine("\t\t\t Book Information System ");
            Console.WriteLine();
            book book1 = new book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "9780743273565");
            book book2 = new book("The 1984", "George Orwell", 1949, "9780451524935");
            book book3 = new book("To Kill a Mockingbird", "Harper Lee", 1960, "9780061120084");

            // Printing book information
            Console.WriteLine("Book Information:");
            Console.WriteLine("_______________________________");
            book1.PrintBookInfo();
            Console.WriteLine("_______________________________");
            book2.PrintBookInfo();
            Console.WriteLine("_______________________________");
            book3.PrintBookInfo();
            Console.WriteLine("_______________________________");
            // Checking if books are older than a given year
            Console.Write("Enter a year to check which books are older than that year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            book1.isOlderThan(year);
            book2.isOlderThan(year);
            book3.isOlderThan(year);


            //Student
            Console.WriteLine("\t\t\t\t Student Report");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            // Creating student objects and printing their reports
            Student student1 = new Student("Alice", 12345, new List<int> { 85, 90 });
            // Adding a new grade and printing the report
            student1.AddGrade(95);
            student1.PrintStudentReport();
            Student student2 = new Student("Bob", 67890, new List<int> { 78, 82, 88 });
            student2.AddGrade(91);
            student2.PrintStudentReport();
            Student student3 = new Student("Charlie", 54321, new List<int> { 92, 87, 85 });
            student3.AddGrade(89);
            student3.PrintStudentReport();


            //Vehicle
            Console.WriteLine("\t\t\t 3: Vehicle Hierarchy System ");
            Console.WriteLine();
            // Creating and displaying information for Car and Truck objects
            Car car = new Car("Toyota", "Camry", 2020, 4);
            // Display car information
            car.DisplayInfo();
            Console.WriteLine();
            // Display truck information
            Truck truck = new Truck("Ford", "F-150", 2019, 2.5);
            truck.DisplayInfo();
            Console.WriteLine();

            //Product and Order
            Console.WriteLine("\t\t\t E-Commerce Order System ");
            Console.WriteLine(); 
            Console.WriteLine("Product Details:");
           
            Product p1= new Product("Laptop", 999.99, 2);
            Product p2= new Product("Smartphone", 499.99, 3);
           
            Order order= new Order();
            order.AddProduct(p1);
            order.AddProduct(p2);
            Console.WriteLine("__________________________________________");
            order.PrintOrderSummary();
            Console.WriteLine();


            //Animal
            Console.WriteLine("\t\t\t Animal Sound Simulation ");
            Console.WriteLine();
            Console.WriteLine("Animal Sounds:");
            Console.WriteLine("__________________________________________");
            // Creating animal objects and making sounds
            Animal animal1 = new Dog("Buddy");
            Animal animal3= new Dog("Max");
            Animal animal2 = new Cat("Whiskers");
            Console.WriteLine();
            animal1.MakeSound();
            animal2.MakeSound();
            animal3.MakeSound();


            //Bank Account System
            Console.WriteLine("\t\t\t Bank Account System ");
            Console.WriteLine();
            Console.WriteLine("Account Transactions:");
            Console.WriteLine("__________________________________________");

            BankAccount acc1 = new BankAccount(1001, "Ali", 500);
            BankAccount acc2 = new BankAccount(1002, "Sara", 1000);
            BankAccount acc3 = new BankAccount(1003, "Omar", 0);
            acc1.Deposit(200);
            acc2.withdraw(150);
            acc3.Deposit(300);
            Console.WriteLine();
            Console.WriteLine("Account Details:");
            acc1.PrintAccountDetails();
            acc2.PrintAccountDetails();
            acc3.PrintAccountDetails();
            Console.WriteLine();
            Console.WriteLine("Total Bank Accounts Created:");
            BankAccount.ShowTotalAccounts();


            //Smart Home Device Control (Hard)

            Console.WriteLine("\t\t\t Smart Home Device Control ");
            Console.WriteLine();
            Console.WriteLine("Device Status:");
            Console.WriteLine("__________________________________________");
            Light livingRoom = new Light();
            Thermostat homeThermostat= new Thermostat();
            Controller controller= new Controller();
            Console.WriteLine("Operating Light:");
            controller.OperatelDevice(livingRoom);
            Console.WriteLine("\nOperating Thermostat:");
            controller.OperatelDevice(homeThermostat);




        }
    }
}
