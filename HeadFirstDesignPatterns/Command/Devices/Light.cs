namespace HeadFirstDesignPatterns.Command;

public class Light
{
  public void On()
  {
    Console.WriteLine("Light is on");  
  }

  public void Off()
  {
    Console.WriteLine("Light is off");
  }
}

public class LightOnCustomCommand : ICustomCommand
{
  public string Name { get; set; } = "Light";

  private Light _light;

  public LightOnCustomCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.On();
  }

  public void Undo()
  {
    _light.Off();
  }
}

public class LightOffCustomCommand : ICustomCommand
{
  public string Name { get; set; } = "Light";

  private Light _light;

  public LightOffCustomCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.Off();
  }
  
  public void Undo()
  {
    _light.On();
  }
}

