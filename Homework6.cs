using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two new professors
            Professor p1 = new Professor("Alice", "Java", 9000); 
            Professor p2 = new Professor("Bob", "Math", 8000);

            // create two new students
            Student s1 = new Student("Lisa", "Java", 90); 
            Student s2 = new Student("Tom", "Math", 80);

            // print name, class, and salary of each professor
            Console.WriteLine("Professor " + p1.GetName() + " teaches " + p1.GetClassTeach() + " and has a salary of $" + p1.GetSalary());
            Console.WriteLine("Professor " + p2.GetName() + " teaches " + p2.GetClassTeach() + " and has a salary of $" + p2.GetSalary());

            // print name, class, and grade of each student
            Console.WriteLine("Student " + s1.studentName + " is enrolled in " + s1.GetClassEnroll() + " and has a grade of " + s1.GetGrade());
            Console.WriteLine("Student " + s2.studentName + " is enrolled in " + s2.GetClassEnroll() + " and has a grade of " + s2.GetGrade());

            // calculate difference in salaries
            double salaryDifference = p1.GetSalary() - p2.GetSalary();
            Console.WriteLine("The difference in salary between " + p1.GetName() + " and " + p2.GetName() + " is $" + salaryDifference);

            // calculate total grade of students
            double totalGrade = s1.GetGrade() + s2.GetGrade();
            Console.WriteLine("The total grade of " + s1.studentName + " and " + s2.studentName + " is " + totalGrade);
        }
    }

    // create Student class
    class Student
    {
        // make name and class public but grade private
        public string studentName;
        public string classEnroll;
        private double studentGrade;

        public Student(string name, string className, double grade)
        {
            studentName = name;
            classEnroll = className;
            studentGrade = grade;
        }

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }

        public string GetClassEnroll()
        {
            return classEnroll;
        }
    }

    // create Professor class
    class Professor
    {
        //make name and class public but salary private
        public string profName;
        public string classTeach;
        private double salary;

        public Professor(string name, string className, double salary)
        {
            profName = name;
            classTeach = className;
            this.salary = salary;
        }

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetName()
        {
            return profName;
        }

        public string GetClassTeach()
        {
            return classTeach;
        }
    }
}