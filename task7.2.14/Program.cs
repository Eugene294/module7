﻿using System;

public class task7_2_14
{
    public static void Main(string[] args)
    {

    }
}

class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }

        set
        {
            array[index] = value;
        }
    }
}
