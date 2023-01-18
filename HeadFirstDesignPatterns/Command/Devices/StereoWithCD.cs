namespace HeadFirstDesignPatterns.Command;

public class StereoWithCD
{
    public void On()
    {
        Console.WriteLine("Stereo is on");
    }

    public void SetCD()
    {
        Console.WriteLine("CD is set");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Volume is set to: {volume}");
    }

    public void Off()
    {
        Console.WriteLine("Stereo is off");
    }
}

public class StereoOnCustomCommand : ICustomCommand
{
    public string Name { get; set; } = "Stereo";

    private StereoWithCD _stereoWithCd;

    public StereoOnCustomCommand(StereoWithCD stereoWithCd)
    {
        _stereoWithCd = stereoWithCd;
    }

    public void Execute()
    {
        _stereoWithCd.On();
        _stereoWithCd.SetCD();
        _stereoWithCd.SetVolume(11);
    }

    public void Undo()
    {
        _stereoWithCd.Off();
    }
}

public class StereoOffCustomCommand : ICustomCommand
{
    public string Name { get; set; } = "Stereo";

    private StereoWithCD _stereoWithCd;
    
    public StereoOffCustomCommand(StereoWithCD stereoWithCd)
    {
        _stereoWithCd = stereoWithCd;
    }

    public void Execute()
    {
        _stereoWithCd.Off();
    }

    public void Undo()
    {
        _stereoWithCd.On();
        _stereoWithCd.SetCD();
        _stereoWithCd.SetVolume(11);
    }
}

