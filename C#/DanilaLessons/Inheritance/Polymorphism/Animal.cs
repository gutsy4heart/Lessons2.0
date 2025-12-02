using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Polymorphism;

public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Животное издает звук");
    }
}
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Собака лает");
    } 
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Кошка мяукает");
    }
}
