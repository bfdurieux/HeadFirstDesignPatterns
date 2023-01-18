using System.Text;

namespace HeadFirstDesignPatterns.Command;

public class RemoteControl
{
    private ICustomCommand[] onCommands;
    private ICustomCommand[] offCommands;
    private ICustomCommand undoCommand;

    public RemoteControl()
    {
        onCommands = new ICustomCommand[7];
        offCommands = new ICustomCommand[7];
        
        var noCommand = new NoCustomCommand();
        Array.Fill(onCommands, noCommand);
        Array.Fill(offCommands, noCommand);
        undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICustomCommand onCustomCommand, ICustomCommand offCustomCommand)
    {
        onCommands[slot] = onCustomCommand;
        offCommands[slot] = offCustomCommand;
    }

    public void OnButtonPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
    }

    public void OffButtonPushed(int slot)
    {
        offCommands[slot].Execute();
    }

    public void UndoButtonPushed()
    {
        undoCommand.Undo();
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("\n----- Remote Control -----\n");

        for (var i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.Append($" Slot {i}: {onCommands[i].Name} \n");
        }

        return stringBuilder.ToString();
    }
}