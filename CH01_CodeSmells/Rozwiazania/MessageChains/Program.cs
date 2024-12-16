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

//Masz kod, który wywołuje łańcuch metod z Library.GetBook().GetAuthor().GetName(). Twoim zadaniem jest wprowadzenie nowej metody GetAuthorName w klasie Library, aby zredukować łańcuch wiadomości.
//Kroki do wykonania:
// 
// 1. Wprowadź metodę GetCylinderSize w klasie Car.
// 1. Przenieś wywołanie zagnieżdżone do nowej metody w klasie Car.
// 1. Zaktualizuj wywołania metod, aby używały nowej metody.
