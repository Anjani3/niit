using System;

class Cricket
{
    public static void Main(string[] args)
    {
        System.Console.Write("\nEnter the total No. of team");
        int teamSize = Convert.ToInt32(Console.ReadLine());

        int[][] Team = new int[teamSize][];
        int[] playMatch = new int[teamSize];

        for(int i=0; i<teamSize; i++)
        {
            System.Console.Write("\nEnter the size of member in  team "+(i+1)+" : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Team[i] = new int[size];
        }

        System.Console.WriteLine("\n\nEnter each Team  member play match");
        for(int i=0; i<Team.Length; i++)
        {
            for(int j=0; j<Team[i].Length; j++)
            {
                System.Console.Write("\nTeam: "+(i+1)+" Member "+(j+1)+": Played match ");
                Team[i][j] = Convert.ToInt32(Console.ReadLine());
                playMatch[i] +=Team[i][j];
                
            }
        }
        System.Console.WriteLine("********************");
         for(int i=0;i<Team.Length;i++)
        {
            System.Console.WriteLine(" Team No : "+(i+1));
            System.Console.WriteLine(" Total No of Member : "+Team[i].Length);
            System.Console.WriteLine(" Total PLayed Match : "+playMatch[i]);

        }
    }
}