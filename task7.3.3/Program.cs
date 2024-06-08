
using System;

public class task7_3_3
{
    public static void Main(string[] args)
    {

    }
}

public abstract class ComputerPart
{

    public abstract void Work();

}

public abstract class Processor : ComputerPart
{

    public override void Work()
    {

    }
}

public abstract class MotherBoard : ComputerPart
{

    public override void Work()
    {

    }

}

public abstract class GraphicCard : ComputerPart
{

    public override void Work() { }

}
