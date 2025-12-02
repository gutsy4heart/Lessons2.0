using Abstraction;

class Program
{
    public static void Main(string[] args)
    {
        Device tv = new TV("LG");
        Device radio = new Radio("Sony");
        Device phone = new Phone("Nokia");

        tv.ShowInfo();
        tv.TurnOn();
        Console.WriteLine();
        radio.ShowInfo();
        radio.TurnOn();
        Console.WriteLine();
        phone.ShowInfo();
        phone.TurnOn();


    }
}