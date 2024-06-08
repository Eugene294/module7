using System;

public class task7_2_12
{
    public static void Main(string[] args)
    {

    }


}

class Obj
{
    public int Value;

    public static Obj operator +(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value
        };
    }
    public static Obj operator -(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }

}
