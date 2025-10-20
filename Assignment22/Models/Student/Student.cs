using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Student
{
    internal class Student
    {
        private string name;
        private int id;
        private List<int> grades;

        public Student(string name, int id, List<int> grades)
        {
            this.name = name;
            this.id = id;
            this.grades = grades;
        }
        public int AddGrade(int grade)
        {
            grades.Add(grade);
            return grade;
        }
        public double CalculateAverageGrade()
        {
            if (grades.Count == 0)
            {
                return 0;
            }
            return grades.Average();
        }
        public void PrintStudentReport()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Grades: {string.Join(", ", grades)}");
        }
    }
}
