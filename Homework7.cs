using System;

namespace Homework7
{
class Program
{
    static void Main(string[] args)
    {
        //create two customers
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);
        //print cust information
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        //change ids
        c1.ChangeID(220);
        c2.ChangeID(221);
        //print again
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        //compare
        c1.CompareAge(c2);
    }
}
//create customer class
class Customer
{
    //private id
    private int cus_id;
    //public age and name
    public int cus_age;
    public string cus_name;
    //this to assign id name and age
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_name = cus_name;
        this.cus_id = cus_id;
        this.cus_age = cus_age;
    }
    //used to change customer id
    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }
    //prints customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {this.cus_id}, name: {this.cus_name}, age:{this.cus_age}");
    }
    //if else statement to compare ages then prints older customer
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        
    }

}
}

