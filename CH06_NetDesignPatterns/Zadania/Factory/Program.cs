using System;
using System.Collections.Generic;
using Factory;



var garnizon = new Squad();
List<Warrior> warriors = new();

Tuple<string, string>[] orders = {
    new Tuple<string, string>("infantry", "Maciej"),
    new Tuple<string, string>("infantry", "Zenon"),
    new Tuple<string, string>("infantry", "Jolanta"),
    new Tuple<string, string>("cavalry", "Anna"),
    new Tuple<string, string>("cavalry", "Tomek"),
    new Tuple<string, string>("cavalry", "Jakub"),
    new Tuple<string, string>("archer", "Mateusz"),
    new Tuple<string, string>("archer", "Barbara"),
    new Tuple<string, string>("archer", "Ola"),
    new Tuple<string, string>("archer", "Paweł"),
};

foreach (var item in orders)
{
    warriors.Add(garnizon.CreateSoldier(item.Item1, item.Item2));
}

foreach (var warrior in warriors)
{
    Console.WriteLine($"Hi, my name is {warrior.Name}, my weapon is {warrior.Weapon}, my level is {warrior.Level}, and my health points are {warrior.HealthPoints}.");
}
        
