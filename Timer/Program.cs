class Program
{
    static void Main(string[] args)
    {
        
        TimerCallback timer = new TimerCallback(Print);
        Timer timer1 = new Timer(timer, null, 0, 1000);

        Console.ReadLine();
    }

    public static void Print(object obj)
    {
            Console.WriteLine("Timer is live");
        
        
    }
}
