using System;

namespace MessageChains
{
    internal class MessageChains
    {
        public class Car
        {
            public string GetCylinderSize()
            {
                Engine engine = new Engine();
                return engine.GetCylinder().GetSize();
            }
        }

        public class Engine
        {
            public Cylinder GetCylinder()
            {
                return new Cylinder();
            }
        }

        public class Cylinder
        {
            public string GetSize()
            {
                return "2.0L";
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                // Przykład wywołania
                Car car = new Car();
                string cylinderSize = car.GetCylinderSize();

                Console.WriteLine($"Cylinder size: {cylinderSize}");
            }
        }
    }
}
