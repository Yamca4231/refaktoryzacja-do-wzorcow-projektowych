using System;

class Program
{
    static void Main(string[] args)
    {
        var factory = new TextureFactory();

        // Tworzenie obiektów z teksturami
        var player = new GameObject("Player", factory.GetTexture("grass.png"));
        var enemy = new GameObject("Enemy", factory.GetTexture("stone.png"));
        var tree = new GameObject("Tree", factory.GetTexture("grass.png"));

        // Renderowanie
        player.Render();
        enemy.Render();
        tree.Render();
    }
}