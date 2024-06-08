using System;

public class task7_2_4
{
    public static void Main(string[] args)
    {

    }
}


class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    private int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            if (value >= 0)
            {
                counter = value;
            }
        }
    }
}
