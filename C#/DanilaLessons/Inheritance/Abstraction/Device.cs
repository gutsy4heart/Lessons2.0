using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction;

public abstract class Device
{
    public string Name { get; set; }
    public Device(string name)
    {
        Name = name;
    }
    public abstract void TurnOn();
    public void ShowInfo()
    {
        Console.WriteLine($"Device: {Name}");
    }
}

public class TV : Device
{
    public TV(string name) : base(name)
    {}
    public override void TurnOn()
    {
        Console.WriteLine("TV turn on");
    }
}

public class Radio : Device
{
    public Radio(string name) : base(name)
    {
    }
    public override void TurnOn()
    {
        Console.WriteLine("Radio turn on");
    }
}

public class Phone : Device
{
    public Phone(string name) : base(name)
    {
    }
    public override void TurnOn()
    {
        Console.WriteLine("Phone turn on");
    }
}

