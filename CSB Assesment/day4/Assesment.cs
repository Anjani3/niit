using System;

class person
{
    string pName;
    int pAge;
    DateTime dt = new DateTime();
    public string pAddress;
    string pEmail;
    long pPhoneNo;
    char pGender;

}
class game
{
  protected string gName;
  protected int gAge;   

class winner : game
{   
     person p = new person();

    public static void Main (string[] args)
    {
       winner wnr = new winner();
       wnr.value();
      
       
    }

    public void value()
    {
        System.Console.WriteLine("Enter the Name :");
        gName = Console.ReadLine();
        System.Console.WriteLine("Enter the age");
        gAge = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Address of the person :");
        p.pAddress =Console.ReadLine();

        System.Console.WriteLine("Name : {0}, Age :{1},  Address : {2}",gName,gAge,p.pAddress);

    }
}
