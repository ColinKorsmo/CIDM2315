namespace Homework5;
class Program
{
    //method for Q1
    static int GetMax(int a, int b) {
        //if else statement for which number is largest
            if (a > b)
            //returns x if it is larger
                return a;
            //returns y if it is larger
            else
                return b;
    }
    //method for Q2 using integers from Q1
    static int GetMax(int a, int b, int c, int d) 
    {
        //max1 takes highest from Q1
        int max1 = GetMax(a, b);
        //max2 takes highest only from Q2
        int max2 = GetMax(c, d);
        //returns highest number from max1 and max2
        return GetMax(max1, max2);
    }
    //CheckAge for Q3 makes sure that the age is above 18 using boolean
    static bool CheckAge(int birth_year) {
        int age = 2022 - birth_year;
        return age >= 18;
    }
    //CreateAccount takes string input for username, password and age for Q3
    static void CreateAccount() {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        Console.Write("Enter your password again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter your birth year: ");
        //converts string input to integer
        int birthYear = Convert.ToInt16(Console.ReadLine());
        // if else statement to check if both passwords are the same
        if (CheckAge(birthYear)) {
            if (password == password2) {
                Console.WriteLine("Account is created successfully");
            } else {
                Console.WriteLine("Wrong password.");
            }
        } else {
            Console.WriteLine("Could not create an account");
        }
    }
    //Main method that takes 4 integers as input
    static void Main() {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        //returns the max of first two numbers only
        int max1 = GetMax(num1, num2);
        Console.WriteLine("The maximum of the first two numbers is: " + max1);

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        int num4 = Convert.ToInt16(Console.ReadLine());
        //returns the max of all four numbers
        int max2 = GetMax(num1, num2, num3, num4);
        Console.WriteLine("The maximum of all four numbers is: " + max2);
        //runs CreateAccount
        CreateAccount();
    }
}
