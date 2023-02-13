namespace Homework4Q2;
class Program
{
         static void Main(string[] args)
        {
            Question1();
            Question2();
        }
            static void Question1()
            {
            //question 1
            //take input for first number and converts it
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            //take input for second number
            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            //create int result and new method
            int result = Largest(num1, num2);
            //prints result
            Console.WriteLine("The largest number is: " + result);
        }
        //new method called Largest to compare nums
        static int Largest(int x, int y)
        {
            //if else statement for which number is largest
            if (x > y)
            //returns x if it is larger
                return x;
            //returns y if it is larger
            else
                return y;
        }
            static void Question2()
            {
            //area to input integer for N
            Console.WriteLine("Enter an whole number for N: ");
            //converts input to int
            int N = Convert.ToInt16(Console.ReadLine());
            //area to input either left or right
            Console.WriteLine("Enter the word 'left' or 'right': ");
            string shape = Console.ReadLine();
            //if else statement to print the inputs
            Console.WriteLine("N is: " + N + "; shape is " + shape);
            if (shape == "left")
                LeftShape(N);
            else if (shape == "right")
                RightShape(N);
        }
        //new method for if the user inputs left
        static void LeftShape(int N)
        {
            for (int a = 1; a <= N; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //new method for if the user inputs right
        static void RightShape(int N)
        {
            for (int a = 1; a <= N; a++)
            {
                for (int b = 1; b <= N - a; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= a; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
        } 
}
}
