using System;

class student
{
    public static void Main(string[] args)
    {
        string[] StudentName = new string[5];
        System.Console.WriteLine("Enter the 5student name ");
        StudentName = getName(StudentName);
     
       int[] sum = new int[5];
        sum = Marks(); 
        displayName(StudentName,sum);


    }

    public static string[] getName(string[] Std)
    {
        for(int i=0;i<5;i++)
        {
            Std[i]=Console.ReadLine();
        
        }
        return Std;
    }

    public static int[] Marks()
    {
        int[] Total = new int[5];
        for(int j=0;j<5;j++){
           System.Console.WriteLine("Enter student "+(j+1)+"'s  3 subject marks");
        int sum=0;
        for(int i=0;i<3;i++)
        {
            
            int m = Convert.ToInt32(Console.ReadLine());
            sum = Convert.ToInt32(sum+m);
        }
       Total[j]=sum;
        }
        return Total;
    }

    public static void displayName(string[] std,int[] sum)
    {
        for(int i=0;i<5;i++)
        {

           int avg = Convert.ToInt32(sum[i]/3);

           if(avg>75)
           {
            System.Console.WriteLine("Name: {0}, Sum: {1}, Grade: A+",std[i],sum[i]);
           }
           else 
           if(avg<=75 && avg>60 )
           {
            System.Console.WriteLine("Name: {0}, Sum: {1}, Grade: A",std[i],sum[i]);
           }
           else
            if(avg<=60 && avg>45)
           {
            System.Console.WriteLine("Name: {0}, Sum: {1}, Grade: B",std[i],sum[i]);
           }
           else
            if(avg<=45 && avg>33)
           {
            System.Console.WriteLine("Name: {0}, Sum: {1}, Grade: C",std[i],sum[i]);
           }
           else{
            System.Console.WriteLine("Name: {0}, Sum: {1}, Grade: Fail",std[i],sum[i]);
           }
        }
    }

}
