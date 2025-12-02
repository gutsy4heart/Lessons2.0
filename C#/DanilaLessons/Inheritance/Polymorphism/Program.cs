using Polymorphism;

public class Program
{
    public static void Main(string[] args)
    {
        //Animal animal = new Animal();
        //Dog bobik = new Dog();
        //Cat murka = new Cat();

        //animal.Speak();
        //bobik.Speak();
        //murka.Speak();



        //List<Shapes> shapes = new List<Shapes>()
        //{
        //    new Circle(5),
        //    new Rectangle(4,6),
        //    new Triangle(3,8)
        //};
        //foreach (var shape in shapes)
        //{
        //    Console.WriteLine($"Тип фигуры: {shape.GetType().Name}");
        //    Console.WriteLine($"Площадь: {shape.GetArea():F2}");
        //    Console.WriteLine();
        //}



        List<Account> accounts = new List<Account>()
            {
                new SavingsAccount(1000),
                new DepositAccount(2000),
                new LoanAccount(1500)
            };


        foreach (Account acc in accounts)
        {
            Console.WriteLine($"{acc.GetType().Name}: баланс = {acc.Balance}, процент = {acc.CalculateInterest()}");
        }

        Console.ReadLine();


      


    }
}