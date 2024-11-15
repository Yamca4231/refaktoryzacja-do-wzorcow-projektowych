using System;

namespace Bridge
{
    public class LinuxSystem : OperatingSystemBase
    {
        public LinuxSystem(Interface systemInterface) : base(systemInterface)
        {
        }

        public override void displayMenu()
        {
            Console.WriteLine("Linux System:");
            _interface.displayMenu();
        }
    }
}