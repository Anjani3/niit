
using System;

class array
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the 5 values in Array");
        int[] arr = new int[5];
        arr = accept_array(arr);

       System.Console.WriteLine("\nArray Ements :  ");
       display(arr);
    }

    public static int[] accept_array(int[] arr)
    {
       
        for(int i=0;i<5;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        return arr;
    }

    public static void display(int[] arr)
    { 
        for(int i=0;i<arr.Length;i++)
        {
        System.Console.Write(arr[i] + " ");
        }
        System.Console.WriteLine();
    }

}
/*   

  int[5] arr =  accept_array(5);

      public static int[] accept_array(int size)
    {
        int[] arr = new int[size];
        for(int i=0;i<size;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        return arr;
    }

*/ 
