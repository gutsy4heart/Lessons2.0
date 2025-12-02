using Interface;

public class Program
{
    public static void Main(string[] args)
    {
        IPayment payment1 = PaymentFactory.CreatePayment(PaymentType.PayPal);

        PaymentService service1 = new PaymentService(payment1);

        service1.ProcessOrder(500);
        service1.ReturnMoney(350);
        Console.WriteLine();
        IPayment payment2 = PaymentFactory.CreatePayment(PaymentType.Crypto);

        PaymentService service2 = new PaymentService(payment2);

        service2.ProcessOrder(500);
        service2.ReturnMoney(350);
        Console.WriteLine();

        IPayment payment3 = PaymentFactory.CreatePayment(PaymentType.Card);

        PaymentService service3 = new PaymentService(payment3);

        service3.ProcessOrder(50);
        service3.ReturnMoney(30);

    }
}