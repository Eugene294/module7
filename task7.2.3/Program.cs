using System;

public class task7_2_3
{
    public static void Main(string[] args)
    {

    }
}


class BaseClass
{

    public virtual void Display()
    {
        Console.WriteLine("Метод базового класса");
    }

}

class DerivedClass : BaseClass
{

    public override void Display()
    {
        Console.WriteLine("Метод класса-наследника");
    }

}
