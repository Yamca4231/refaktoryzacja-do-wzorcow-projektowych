using System;

using Bridge;

public class Program
{
    public static void Main(string[] args)
    {
        // Tworzenie instancji systemu Linux z interfejsem graficznym
        OperatingSystemBase linuxWithGraphicInterface = new LinuxSystem(new GraphicInterface());
        linuxWithGraphicInterface.displayMenu();

        Console.WriteLine();

        // Tworzenie instancji systemu Windows z interfejsem tekstowym
        OperatingSystemBase windowsWithTextInterface = new WindowsSystem(new TextInterface());
        windowsWithTextInterface.displayMenu();

        Console.ReadLine();
    }
}
