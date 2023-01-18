// See https://aka.ms/new-console-template for more information

using HeadFirstDesignPatterns.Command;

var remote = new RemoteControl();
var light = new Light();
var garageDoor = new GarageDoor();
var stereo = new StereoWithCD();
var ceilingFan = new CeilingFan("living room");
remote.SetCommand(0, new LightOnCustomCommand(light), new LightOffCustomCommand(light));
remote.SetCommand(1, new GarageDoorOpenCustomCommand(garageDoor), new GarageDoorClosedCustomCommand(garageDoor));
remote.SetCommand(2, new StereoOnCustomCommand(stereo), new StereoOffCustomCommand(stereo));
remote.SetCommand(3, new CeilingFanHighCommand(ceilingFan), new CeilingFanOffCommand(ceilingFan));
remote.SetCommand(4, new CeilingFanMediumCommand(ceilingFan), new CeilingFanOffCommand(ceilingFan));
remote.SetCommand(5, new CeilingFanLowCommand(ceilingFan), new CeilingFanOffCommand(ceilingFan));

// remote.OnButtonPushed(0);
// remote.OnButtonPushed(1);
// remote.OnButtonPushed(2);
// remote.OffButtonPushed(0);
// remote.OffButtonPushed(1);
// remote.OffButtonPushed(2);
//
// remote.OnButtonPushed(4);
// remote.OffButtonPushed(4);
// remote.UndoButtonPushed();
//
// remote.OnButtonPushed(3);
// remote.UndoButtonPushed();

// party time
// var partyLight = new Light();
// var partyStereo = new StereoWithCD();
//
// var lightOn = new LightOnCustomCommand(partyLight);
// var stereoOn = new StereoOnCustomCommand(partyStereo);
// var lightOff = new LightOffCustomCommand(partyLight);
// var stereoOff = new StereoOffCustomCommand(partyStereo);
// var partyOn = new ICustomCommand[] {lightOn, stereoOn};
// var partyOff = new ICustomCommand[] {lightOff, stereoOff};
//
// var partyOnMacro = new MacroCommand(partyOn);
// var partyOffMacro = new MacroCommand(partyOff);
//
// remote.SetCommand(6, partyOnMacro, partyOffMacro);
//
// remote.OnButtonPushed(6);
// remote.OffButtonPushed(6);


int solution(int N) {
    // Implement your solution here
    var binary = Convert.ToString(N,2).ToCharArray();

    var buffer = 0;
    var stack = new List<int>();
    foreach (var t in binary)
    {
        if(t == '1') {
            stack.Add(buffer);
            buffer = 0;
        } else {
            buffer++;
        }
    }
    return stack.Count == 0 ? 0 : stack.Max();
}


Console.WriteLine(solution(1041).ToString());
Console.ReadKey();

