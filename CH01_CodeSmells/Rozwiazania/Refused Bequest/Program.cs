using System;

namespace Refused_Bequest
{
    // Krok 1: Utworzenie interfejsu IEmployee
    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }

    // Klasa Employee implementuje IEmployee
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"{Name} is attending a meeting.");
        }
    }

    // Krok 2: Usunięcie dziedziczenia i użycie interfejsu
    public class Manager : IEmployee
    {
        public string Name { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is managing work.");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"{Name} is leading a meeting.");
        }

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee { Name = "John Doe", Position = "Developer" };
            employee.Work();
            employee.AttendMeeting();

            IEmployee manager = new Manager { Name = "Jane Smith" };
            manager.Work();
            manager.AttendMeeting();

            // Dodatkowe wywołanie specyficzne dla Managera
            Manager specificManager = new Manager { Name = "Jane Smith" };
            specificManager.ManageTeam();

            Console.ReadLine();
        }
    }
}