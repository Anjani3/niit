using System;



    class program
    {
          public static void Main(string[] args)
          {
             program pr = new program();

        System.Console.WriteLine("Enter a value ");
        int n = pr.getValue();
       System.Console.WriteLine("Number after multiply by 5 :  "+pr.calc(n));
        

          }
      public int getValue()
        {
        int num = Convert.ToInt32(Console.ReadLine());
        return num;

        }
        public int calc(int n)
        {
            return n*5;
        }
    }
