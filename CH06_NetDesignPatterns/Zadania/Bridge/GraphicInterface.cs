using System;

namespace Bridge
{
    public class GraphicInterface : Interface
    {
        public override void displayMenu()
        {
            Console.WriteLine("Wyświetlanie graficznego menu...");
            Console.WriteLine("1. Program A");
            Console.WriteLine("2. Program B");
            Console.WriteLine("3. Program C");
        }
    }
}