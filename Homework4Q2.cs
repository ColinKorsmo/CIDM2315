namespace Homework4Q2;
class Program
{
        //created two seperate programs for each question
         static void Main(string[] args)
        {
            //area to input integer for N
            Console.WriteLine("Enter an whole number for N: ");
            //converts input to int
            int N = Convert.ToInt16(Console.ReadLine());
            //area to input either left or right
            Console.WriteLine("Enter the word 'left' or 'right': ");
            string shape = Convert.ToString(Console.ReadLine()!).ToLower();
            //if else statement to print the inputs
            Console.WriteLine("N is: " + N + "; shape is " + shape);
            if (shape.ToLower() == "left")
                LeftShape(N);
            else if (shape.ToLower() == "right")
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