using System;
using System.Collections.Generic;

// Interfejs dla wszystkich komponentów
public interface IComponent
{
    void Display();
}

// Liść - podstawowy element
public class Leaf : IComponent
{
    private string _name;
    public Leaf(string name)
    {
        _name = name;
    }
    public void Display()
    {
        Console.WriteLine($"Leaf: {_name}");
    }
}

// Kompozyt, który może zawierać inne komponenty
public class Composite : IComponent
{
    private List<IComponent> _children = new List<IComponent>();
    public void Add(IComponent component)
    {
        _children.Add(component);
    }
    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }
    public void Display()
    {
        foreach (var child in _children)
        {
            child.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        var root = new Composite();
        root.Add(new Leaf("Liść 1"));
        root.Add(new Leaf("Liść 2"));
        var composite = new Composite();
        composite.Add(new Leaf("Liść 3"));
        composite.Add(new Leaf("Liść 4"));
        root.Add(composite);
        root.Display();
    }
}
