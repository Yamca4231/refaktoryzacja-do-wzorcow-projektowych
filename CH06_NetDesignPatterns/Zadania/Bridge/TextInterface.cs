using System;

namespace Bridge
{
    public class TextInterface : Interface
    {
        public override void displayMenu()
        {
            Console.WriteLine("Wyświetlanie menu tekstowego...");
            Console.WriteLine("1. Program X");
            Console.WriteLine("2. Program Y");
            Console.WriteLine("3. Program Z");
        }
    }
}