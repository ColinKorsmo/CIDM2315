namespace Homework2;
class program
{
    static void Main(string[] args)
    {
    //to enter a letter grade
    Console.WriteLine("Enter a letter grade:");
            //converts any input to uppercase
            string letter = Console.ReadLine().ToUpper();
            //switch statement for letters a-f and default for any other inputs
            switch (letter)
            {
                case "A":
                    Console.WriteLine("GPA point: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA point: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA point: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA point: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA point: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }
            //area for user input
            Console.WriteLine("Enter the first number:");
            //creates int for input 1
            int num1 = int.Parse(Console.ReadLine());
            //input 2
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            //input 3
            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());
            //makes num1 the smallest for comparison
            int smallest_number = num1;
            //if else statements for comparison of num2 and num3
            if (num2 < smallest_number)
            {
                //if num3 is smaller than num2
                if (num3 < num2)
                {
                    smallest_number = num3;
                }
                //if num2 is smaller than num1 and num3
                else
                {
                    smallest_number = num2;
                }
            }
            //if num3 is smaller than num1
            else if (num3 < smallest_number)
            {
                smallest_number = num3;
            }
            
            Console.WriteLine("The smallest number is: " + smallest_number);
        }
    }


