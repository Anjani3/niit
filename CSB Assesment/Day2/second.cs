// Accept a number from user in program cs pass that number to another class method and multiply that number by 5 print it in program.cs

using System;

class user
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a value");
        int a = Convert.ToInt32(Console.ReadLine());
      // int num= calc.multiply(a);
      int num = a*5;
        System.Console.WriteLine(" Number after multiply by 5 : "+num); 
    }
}
// class calc
// {
//     public static int multiply(int n)
//     {
//         return n*5;
//     }
// }