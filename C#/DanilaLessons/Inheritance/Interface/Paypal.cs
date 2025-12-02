using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public interface IPayment
{
    string ProviderName {  get; }
    bool Pay(decimal amount);
    bool Refund(decimal amount);
}
public class PayPalPayment : IPayment
{
    public string ProviderName => "PayPal";

    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} через PayPal...");
        return true;
    }

    public bool Refund(decimal amount)
    {
        Console.WriteLine($"Возврат {amount} через PayPal...");
        return true;
    }
}
public class CardPayment : IPayment
{
    public string ProviderName => "Credit/Debit Card";

    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} через банковской картой...");
        return true;
    }

    public bool Refund(decimal amount)
    {
        Console.WriteLine($"Возврат {amount} через банковской картой...");
        return true;
    }
}

public class CryptoPayment : IPayment
{
    public string ProviderName => "Crypto";

    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Оплата {amount} криптовалютой...");
        return true;
    }

    public bool Refund(decimal amount)
    {
        Console.WriteLine($"Возврат {amount} криптовалютой...");
        return true;
    }
}
public enum PaymentType
{
    PayPal,
    Card,
    Crypto
}
public static class PaymentFactory
{
    public static IPayment CreatePayment(PaymentType type)
    {
        return type switch
        {
            PaymentType.PayPal => new PayPalPayment(),
            PaymentType.Card   => new CardPayment(),
            PaymentType.Crypto => new CryptoPayment(),
            _ => throw new ArgumentException("Неизвестный тип оплаты")
        };
    }

}

public class PaymentService
{
    private readonly IPayment _payment;
    public PaymentService(IPayment payment)
    {
        _payment = payment;
    }
    public void ProcessOrder(decimal amount)
    {
        Console.WriteLine($"Используем {_payment.ProviderName}");
        bool success = _payment.Pay(amount);
        if (success) { Console.WriteLine("Оплата прошла успешно!"); }
        else { Console.WriteLine("Ошибка оплаты!"); }
    }
    public void ReturnMoney(decimal amount)
    {
        bool success = _payment.Refund(amount);
        if (success) { Console.WriteLine("Возврат прошел успешно!"); }
        else { Console.WriteLine("Ошибка возврата!"); }
    }
}