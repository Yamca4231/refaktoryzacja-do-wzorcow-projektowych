using System;
using System.Collections.Generic;

// Interfejs wspólny dla pozycji menu
public interface IMenuComponent
{
    void Display(string indent);
}

// Klasa liścia: Danie
public class MenuItem : IMenuComponent
{
    public string Name { get; }
    public decimal Price { get; }

    public MenuItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}{Name} - {Price:F2} PLN");
    }
}

// Klasa kompozytu: Kategoria menu
public class MenuCategory : IMenuComponent
{
    public string Name { get; }
    private readonly List<IMenuComponent> _components = new List<IMenuComponent>();

    public MenuCategory(string name)
    {
        Name = name;
    }

    public void Add(IMenuComponent component)
    {
        _components.Add(component);
    }

    public void Remove(IMenuComponent component)
    {
        _components.Remove(component);
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}{Name}:");
        foreach (var component in _components)
        {
            component.Display(indent + "  ");
        }
    }
}