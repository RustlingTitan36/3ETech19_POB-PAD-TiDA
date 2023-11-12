using System;

class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("Wywołano OperationA w SubsystemA");
    }
}

class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("Wywołano OperationB w SubsystemB");
    }
}

class Facade
{
    private SubsystemA subsystemA;
    private SubsystemB subsystemB;

    public Facade()
    {
        subsystemA = new SubsystemA();
        subsystemB = new SubsystemB();
    }

    public void DoComplexOperation()
    {
        Console.WriteLine("Rozpoczynam złożoną operację...");
        subsystemA.OperationA();
        subsystemB.OperationB();
        Console.WriteLine("Zakończono złożoną operację.");
    }
}

class Program
{
    public static void Main()
    {
        Facade facade = new Facade();
        facade.DoComplexOperation();
    }
}
