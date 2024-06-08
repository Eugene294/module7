using System;

public class task7_2_5
{
    public static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();
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
        base.Display();
        Console.WriteLine("Метод класса-наследника");
    }

}
