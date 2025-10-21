using Assignment22.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Employee
{
   public  class Employee
    {
        public string Name { get; set; }
        public double Salary;



        public Employee(string name, double salary) {
            if (salary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            Name = name; ;
        Salary = salary;
        }

        public virtual double CalculateBonus(double salary)
        {
            return salary * 0.1;

        }
    }
}
//Create 2 derived classes:
//- Manager → 20% bonus
//Developer → 15 % bonus
public class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus(double salary)
    {
        return Salary * 0.20; // 20% bonus
    }
}
public class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus(double salary)
    {
        return Salary * 0.15; // 15% bonus
    }
}
public class HR {
    //Create an HR class that takes a list of employees and prints their bonuses using polymorphism.
    private List<Employee> employees;
    public HR(List<Employee> employees = null)
    {

        this.employees = employees;
        this.employees = employees;
    }
    public void PrintEmployeeBonuses(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            double bonus = employee.CalculateBonus(employee.Salary);
            Console.WriteLine($"Employee: {employee.Name}, Bonus: {bonus:F2}");
        }
    }
}


