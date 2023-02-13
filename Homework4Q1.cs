namespace Homework4Q1;
class Program
{
    //used two seperate consoles for homework questions due to errors
    static void Main(string[] args)
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
}
