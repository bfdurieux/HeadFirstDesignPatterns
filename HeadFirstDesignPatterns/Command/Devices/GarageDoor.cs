namespace HeadFirstDesignPatterns.Command;

public class GarageDoor
{
    public void Open()
    {
        Console.WriteLine("Garage door is open");
    }

    public void Close()
    {
        Console.WriteLine("Garage door is closed");
    }
}

public class GarageDoorOpenCustomCommand : ICustomCommand
{
    public string Name { get; set; } = "Garage Door";

    private GarageDoor _garageDoor;
    
    public GarageDoorOpenCustomCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Open();
    }

    public void Undo()
    {
        _garageDoor.Close();
    }
}

public class GarageDoorClosedCustomCommand : ICustomCommand
{
    public string Name { get; set; } = "Garage Door";

    private GarageDoor _garageDoor;
    
    public GarageDoorClosedCustomCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Close();
    }
    
    public void Undo()
    {
        _garageDoor.Open();
    }
}