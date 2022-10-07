using System; 

class sellTicket
{

    public static int ticketNo;

    static sellTicket()
    {
        ticketNo = 10;
    }

    public static void Main(string[] args)
    {
        sellTicket st = new sellTicket();
        System.Console.WriteLine("you have sold total no. of ticket :"+ticketNo);
        st.selltct();
        System.Console.WriteLine("you have sell total no. of ticket :"+ticketNo);
         
        sellTicket st2 = new sellTicket();         
        st2.selltct();
        System.Console.WriteLine("you have sell total no. of ticket :"+ticketNo);
    }

    public void selltct()
    {
        System.Console.WriteLine("You want to sell Ticket Y/N ");
        char ch = Convert.ToChar(Console.ReadLine());
       if(ch=='y' || ch== 'Y')
       {
            System.Console.WriteLine("Enter the number of ticket");
            int n = Convert.ToInt32(Console.ReadLine());
            ticketNo = ticketNo+n;
       }
       else
       {
        System.Console.WriteLine("You should sell the ticket");
       }
    }
}