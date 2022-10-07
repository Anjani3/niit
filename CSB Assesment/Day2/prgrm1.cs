using System;

   
class prgrm1
{
    public static void Main(string[] args)
    {
        Person Raju = new Person();
        System.Console.WriteLine("Enter the Age of the person");
        byte Age = Raju.getValue();
        System.Console.WriteLine("Age = "+Age);
    }
   
   
}

class Person
{
    public byte getValue()
    {
        byte n = Convert.ToByte(Console.ReadLine());
        
        return Convert.ToByte
        (n+20);
    }
}
   