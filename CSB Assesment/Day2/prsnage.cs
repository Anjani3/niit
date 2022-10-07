using System;

   
class prgrm1
{
    public static void Main(string[] args)
    {
        Person Raju = new Person();
        System.Console.WriteLine("Enter the Age of the person");
        byte Age = Convert.ToByte(Console.ReadLine());
        
        System.Console.WriteLine("Age = "+Raju.calc_Age(Age));
    }
   
   
}

class Person
{
    public byte calc_Age(byte n)
    {
      //  byte n = Convert.ToByte(Console.ReadLine());
        
        return Convert.ToByte(n+20);
    }
}