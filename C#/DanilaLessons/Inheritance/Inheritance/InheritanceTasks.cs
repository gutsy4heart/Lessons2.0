using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;


class Transport
{
    public string Brand { get; set; }
    public int Speed { get; set; }
    public Transport(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Скорость: {Speed} км/ч");
    }
}


class Car : Transport
{
    public string FuelType { get; set; }
    public Car(string brand, int speed, string fuelType)
        : base(brand, speed)
    {
        FuelType = fuelType;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип топлива: {FuelType}");
    }
}


class Bicycle : Transport
{
    public bool HasBell { get; set; }
    public Bicycle(string brand, int speed, bool hasBell)
        : base(brand, speed)
    {
        HasBell = hasBell;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Есть звонок: {(HasBell ? "Да" : "Нет")}");
    }
}


class Bus : Transport
{
    public int PassengerCapacity { get; set; }
    public Bus(string brand, int speed, int passengerCapacity)
        : base(brand, speed)
    {
        PassengerCapacity = passengerCapacity;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Вместимость пассажиров: {PassengerCapacity}");
    }

}
