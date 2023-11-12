using System;

// Istniejący interfejs
interface IExistingInterface
{
    void SomeMethod();
}

// Istniejąca implementacja interfejsu
class ExistingImplementation : IExistingInterface
{
    public void SomeMethod()
    {
        Console.WriteLine("Existing implementation method.");
    }
}

// Nowy interfejs, który chcemy wykorzystać
interface INewInterface
{
    void NewMethod();
}

// Implementacja adaptera, aby użyć istniejącego interfejsu z nowym interfejsem
class Adapter : INewInterface
{
    private IExistingInterface existing;
    public Adapter(IExistingInterface existing)
    {
        this.existing = existing;
    }
    public void NewMethod()
    {
        // Wywołanie istniejącej metody, dostosowanej do nowego interfejsu
        existing.SomeMethod();
    }
}

// Użycie adaptera
class Program
{
    public static void Main()
    {
        // Istniejąca implementacja
        IExistingInterface existingImplementation = new ExistingImplementation();
        // Użycie adaptera, aby dostosować istniejący interfejs do nowego interfejsu
        INewInterface adapter = new Adapter(existingImplementation);
        // Wywołanie nowej metody za pomocą adaptera
        adapter.NewMethod();
    }
}
