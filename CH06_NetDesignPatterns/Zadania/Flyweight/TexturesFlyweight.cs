using System;
using System.Collections.Generic;

// Tekstura współdzielona
public class Texture
{
    public string FileName { get; }

    public Texture(string fileName)
    {
        FileName = fileName;
        Console.WriteLine($"Loading texture: {fileName}");
    }

    public void Display(string context)
    {
        Console.WriteLine($"Displaying '{FileName}' for {context}");
    }
}

// Fabryka tekstur
public class TextureFactory
{
    private readonly Dictionary<string, Texture> _textures = new();

    public Texture GetTexture(string fileName)
    {
        if (!_textures.ContainsKey(fileName))
        {
            _textures[fileName] = new Texture(fileName);
        }
        return _textures[fileName];
    }
}

// Obiekt gry
public class GameObject
{
    public string Name { get; }
    private readonly Texture _texture;

    public GameObject(string name, Texture texture)
    {
        Name = name;
        _texture = texture;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering {Name}");
        _texture.Display(Name);
    }
}