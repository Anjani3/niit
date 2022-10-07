using System;

class marks{
        public static void Main(string[] args)
        {
         //   System.Console.WriteLine("Enter a value ");
           // int a = Convert.ToInt32(Console.ReadLine());
            int p = calc();
            System.Console.Write("\nValue after calculatio : "+p);

            // program - 6

            string[] name = new string[3];
            System.Console.WriteLine("\n\nenter 3 name :");
            for(int i=0;i<3;i++){
                name[i] = Console.ReadLine();
            }
            display_Name(name);

        }
        public static int calc()
        {
             System.Console.WriteLine("Enter a value ");
             int n = Convert.ToInt32(Console.ReadLine());
             
            int p = n<100? n+100: (n>100 && n<200)? n+50: n;
            return p;
        }
        public static void  display_Name(string[] name)
        {
             for(int i=0;i<3;i++){
                System.Console.WriteLine("Hello i am No: "+(i+1)+"- "+name[i]);
            }
        }
}