using Assignment22.Models.Book;
using Assignment22.Models.Student;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "9780743273565");
            book book2 = new book("The 1984", "George Orwell", 1949, "9780451524935");
            book book3 = new book("To Kill a Mockingbird", "Harper Lee", 1960, "9780061120084");

            Console.WriteLine("Book Information:");
            Console.WriteLine("_______________________________");
            book1.PrintBookInfo();
            Console.WriteLine("_______________________________");
            book2.PrintBookInfo();
            Console.WriteLine("_______________________________");
            book3.PrintBookInfo();
            Console.WriteLine("_______________________________");

            Console.Write("Enter a year to check which books are older than that year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            book1.isOlderThan(year);
            book2.isOlderThan(year);
            book3.isOlderThan(year);

            //Student
            Console.WriteLine("\t\t\t\t Student Report");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Student student1 = new Student("Alice", 12345, new List<int> { 85, 90 });
            student1.AddGrade(95);
            student1.PrintStudentReport();
            Student student2 = new Student("Bob", 67890, new List<int> { 78, 82, 88 });
            student2.AddGrade(91);
            student2.PrintStudentReport();
            Student student3 = new Student("Charlie", 54321, new List<int> { 92, 87, 85 });
            student3.AddGrade(89);
            student3.PrintStudentReport();


            //Vehicle
            Console.WriteLine("\t\t\t Vehicle Information");
            Console.WriteLine();
            Car car = new Car("Toyota", "Camry", 2020, 4);
            car.DisplayInfo();
            Console.WriteLine();
            Truck truck = new Truck("Ford", "F-150", 2019, 2.5);
            truck.DisplayInfo();
            Console.WriteLine();

        }
    }
}
