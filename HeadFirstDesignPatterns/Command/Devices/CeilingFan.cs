
namespace HeadFirstDesignPatterns.Command;

public class CeilingFan
{
    public static readonly int HIGH = 3;
    public static readonly int MEDIUM = 2;
    public static readonly int LOW = 1;
    public static readonly int OFF = 0;
    private string _location;
    private int _speed;

    public CeilingFan(string location)
    {
        _location = location;
        _speed = OFF;
    }

    public void high()
    {
        _speed = HIGH;
        Console.WriteLine("Ceiling fan on High");
    }

    public void medium()
    {
        _speed = MEDIUM;
        Console.WriteLine("Ceiling fan on Medium");
    }

    public void low()
    {
        _speed = LOW;
        Console.WriteLine("Ceiling fan on Low");
    }

    public void off()
    {
        _speed = OFF;
        Console.WriteLine("Ceiling fan is Off");
    }

    public int getSpeed()
    {
        return _speed;
    }
}

public class CeilingFanHighCommand: ICustomCommand
{
    public string Name { get; set; } = "Ceiling Fan HIGH";
    private CeilingFan _ceilingFan;
    private int prevSpeed;
    
    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = _ceilingFan.getSpeed();
        _ceilingFan.high();
    }

    public void Undo()
    {
        if (prevSpeed == CeilingFan.HIGH)
            _ceilingFan.high();
        if(prevSpeed == CeilingFan.MEDIUM)
            _ceilingFan.medium();
        if(prevSpeed == CeilingFan.LOW)
            _ceilingFan.low();
        if(prevSpeed == CeilingFan.OFF)
            _ceilingFan.off();
    }
}

public class CeilingFanMediumCommand: ICustomCommand
{
    public string Name { get; set; } = "Ceiling Fan MEDIUM";
    private CeilingFan _ceilingFan;
    private int prevSpeed;
    
    public CeilingFanMediumCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = _ceilingFan.getSpeed();
        _ceilingFan.medium();
    }

    public void Undo()
    {
        if (prevSpeed == CeilingFan.HIGH)
            _ceilingFan.high();
        if(prevSpeed == CeilingFan.MEDIUM)
            _ceilingFan.medium();
        if(prevSpeed == CeilingFan.LOW)
            _ceilingFan.low();
        if(prevSpeed == CeilingFan.OFF)
            _ceilingFan.off();
    }
}

public class CeilingFanLowCommand: ICustomCommand
{
    public string Name { get; set; } = "Ceiling Fan LOW";
    private CeilingFan _ceilingFan;
    private int prevSpeed;
    
    public CeilingFanLowCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = _ceilingFan.getSpeed();
        _ceilingFan.low();
    }

    public void Undo()
    {
        if (prevSpeed == CeilingFan.HIGH)
            _ceilingFan.high();
        if(prevSpeed == CeilingFan.MEDIUM)
            _ceilingFan.medium();
        if(prevSpeed == CeilingFan.LOW)
            _ceilingFan.low();
        if(prevSpeed == CeilingFan.OFF)
            _ceilingFan.off();
    }
}

public class CeilingFanOffCommand: ICustomCommand
{
    public string Name { get; set; } = "Ceiling Fan OFF";
    private CeilingFan _ceilingFan;
    private int prevSpeed;
    
    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        prevSpeed = _ceilingFan.getSpeed();
        _ceilingFan.off();
    }

    public void Undo()
    {
        if (prevSpeed == CeilingFan.HIGH)
            _ceilingFan.high();
        if(prevSpeed == CeilingFan.MEDIUM)
            _ceilingFan.medium();
        if(prevSpeed == CeilingFan.LOW)
            _ceilingFan.low();
        if(prevSpeed == CeilingFan.OFF)
            _ceilingFan.off();
    }
}