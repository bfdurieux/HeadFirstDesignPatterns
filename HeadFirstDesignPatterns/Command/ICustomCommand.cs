namespace HeadFirstDesignPatterns.Command;

public interface ICustomCommand
{
    public string Name { get; set; }
    public void Execute() {}
    
    public void Undo() {}
}

public class NoCustomCommand : ICustomCommand
{
    public string Name { get; set; } = "No Command";

    public void Execute()
    {
        Console.WriteLine("No Command");
    }

    public void Undo()
    {
        Console.WriteLine("No Command");
    }
}