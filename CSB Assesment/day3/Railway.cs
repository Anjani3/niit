using System;

class Railway
{
   
    float basePrice;
    float TotalPrice;
    int gst;

    public float _basePrice
    {
        get{return basePrice;}
        set{ basePrice = value; }
    }

    public int gst
    {
        get {return gst;}
    }
     public Railway()
     {
        gst = 10;
        basePrice =200;
     }

     public void TicketPrice()
     {
        TicketPrice = basePrice + (basePrice*gst)/100;
     }




    public static void Main(string[] args)
    {
        Railway rw = new Railway(100.0f);

    }

    
}