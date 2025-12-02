using IEnumerable;

public class Program
{
    public static void Main(string[] args)
    {
        var lib = new Library();
        lib.Add(new Book("Master and Margarita", "Devil romance", 500));
        lib.Add(new Book("Metro 2033", "Sci-Fi", 300));
        lib.Add(new Book("Young Samurai", "Historical", 400));

        Console.WriteLine("All Books:");
        foreach (var item in lib)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("By Genre:");
        Console.WriteLine();
        foreach (var item in lib.GetByGenre("Fantasy"))
        {
            Console.WriteLine(item);
        }

        foreach (var item in lib.GetByGenre("Devil romance"))
        {
            Console.WriteLine(item);
        }
        foreach (var item in lib.GetByGenre("Historical"))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Expensive books:");
        foreach (var item in lib.GetExpensive(1000))
        {
            Console.WriteLine(item);
        }
    }
}