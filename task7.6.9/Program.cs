using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Engine { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }



}
