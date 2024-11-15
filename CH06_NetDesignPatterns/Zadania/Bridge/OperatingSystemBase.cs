using System;

namespace Bridge
{
    public abstract class OperatingSystemBase
    {
        protected Interface _interface;

        public OperatingSystemBase(Interface systemInterface)
        {
            _interface = systemInterface;
        }

        public abstract void displayMenu();
    }
}