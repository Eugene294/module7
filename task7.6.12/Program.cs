﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Engine { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    abstract class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
}
