namespace Homework9;
public class Student {
    public int StudentID { get; set; }
    public string StudentName { get; set; }

    public Student(int id, string name) {
        StudentID = id;
        StudentName = name;
    }

    public void PrintInfo() {
        Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
    }
}

class Program {
    static void Main(string[] args) {
        var students = new List<Student> {
            new Student(111, "Alice"),
            new Student(222, "Bob"),
            new Student(333, "Cathy"),
            new Student(444, "David")
        };

        var gradebook = new Dictionary<string, double> {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        if (!gradebook.ContainsKey("Tom")) {
            gradebook.Add("Tom", 3.3);
        }

        var totalGPA = gradebook.Values.Sum();
        var averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        Console.WriteLine("The students with a GPA greater than the average GPA:");
        foreach (var student in students) {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA) {
                student.PrintInfo();
            }
        }
    }
}

