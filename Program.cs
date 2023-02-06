namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
    //question 1
    //enter a number
    Console.WriteLine("Input an integer:");
    //convert input to integer
    int n = Convert.ToInt16(Console.ReadLine());
    //after troubleshooting why the prime numbers were being printed multiple times, created a bool var to help deter that
    bool isPrime = true;
            //for loop using i as variable for comparison
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            //new if else statement to print isPrime var
            if (isPrime)
                {
                    Console.WriteLine(n + " is prime.");
                }
            else {
                    Console.WriteLine(n + " is not prime."); 
            }
    //question 2
    //enter a number
    Console.WriteLine("Assign an int value to x:");
    //convert input to int
    int x = Convert.ToInt16(Console.ReadLine());
    //nested for loop to print row and column equal to x
    for(int row = 0; row<x; row++){
        for(int col = 0; col<x; col++)
        {
            Console.Write('#');
        }
        Console.WriteLine("");
    }
    //question 3
    //enter a number
    Console.WriteLine("Assign a value to y:");
    //convert input to int
    int y = Convert.ToInt16(Console.ReadLine());
    //nested for loop to print row and column increasing by 1 from value y
    for(int row = 0; row<y; row++){
        for(int col = 0; col<y; col++)
        {
            if(row>=col)
                Console.Write('*');
        }
        Console.WriteLine("");
    }
}
}