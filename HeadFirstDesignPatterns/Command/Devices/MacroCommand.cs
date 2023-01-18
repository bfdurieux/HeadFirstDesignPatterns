namespace HeadFirstDesignPatterns.Command;

public class MacroCommand : ICustomCommand
{
    public string Name { get; set; } = "Macro Command";

    private ICustomCommand[] _commands;
    
    public MacroCommand(ICustomCommand[] commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        foreach (var customCommand in _commands)
        {
            customCommand.Execute();
        }
    }
}