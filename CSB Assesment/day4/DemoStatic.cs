using System;

 class DemoStatic
{
    static int value=12;
    string str = "hi";
    public static void Main(string[] args)
    {
        DemoStatic ds = new DemoStatic();
        ds.display();
        
        Console.WriteLine(DemoStatic.value+24);  // 
        Console.WriteLine(ds.str);
  //      Demo d = new Demo();                              cannot be  initiated
        Demo.show();
    }

    public void display()
    {
        Console.WriteLine(value);
    }
}
static class Demo
{
  //  int a;                            cannot declare
    public static void show()
    {
        Console.WriteLine("this is demo class");
    }

}