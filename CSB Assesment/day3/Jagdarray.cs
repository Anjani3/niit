using System;

class Jagdarray
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("Enter the size of Ticket counter: ");
        int m = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine("Enter the size of member at each counter:  ");
        // int n = Convert.ToInt32(Console.ReadLine());

        int[][] jagTickt = new int[m][];
         int[] TotalAmount = new int[m];

         for(int i=0; i<m; i++)
         {
            System.Console.WriteLine("Total No. of ticket in counter "+(i+1)+" : ");
            int size_ticket = Convert.ToInt32(Console.ReadLine());
            jagTickt[i] = new int[size_ticket];
         }

        System.Console.WriteLine("Enter the price of ticket for each counter ");
        for(int i=0; i<jagTickt.Length; i++)
    Convert.ToInt32(Console.ReadLine());    {
           
            for(int j=0; j<jagTickt[i].Length; j++)
            {   
                System.Console.WriteLine("Counter "+(i+1)+" Enter"+(j+1)+" ticket price :");
                jagTickt[i][j] = Convert.ToInt32(Console.ReadLine());
                TotalAmount[i] +=jagTickt[i][j];
            }

          
        }

        for(int i=0;i<jagTickt.Length;i++)
        {
            System.Console.WriteLine(" Counter No : "+(i+1));
            System.Console.WriteLine(" Total No of ticket purchase : "+jagTickt[i].Length);
            System.Console.WriteLine(" Total Amount : "+TotalAmount[i]);

        }


    }
}