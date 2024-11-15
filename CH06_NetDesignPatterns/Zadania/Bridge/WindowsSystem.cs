using System;

namespace Bridge
{
    public class WindowsSystem : OperatingSystemBase
    {
        public WindowsSystem(Interface systemInterface) : base(systemInterface)
        {
        }

        public override void displayMenu()
        {
            Console.WriteLine("Windows System:");
            _interface.displayMenu();
        }
    }
}