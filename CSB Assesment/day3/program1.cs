using System;

class program1
{
    int a;
    float b;
    string str;

    program1(int a)
    {
        this.a=a;
        this.b = b;
        this.str = "hello";

    }

    public static void Main(string[] args)
    {
        program1 pr = new program1(200);
            pr.display();
    }
    public void display()
    {
        System.Console.WriteLine(a+" "+ b+ " "+str);
    }
}