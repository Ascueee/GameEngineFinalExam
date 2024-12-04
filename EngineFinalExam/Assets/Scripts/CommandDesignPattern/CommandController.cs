using UnityEngine;

public class CommandController : MonoBehaviour
{
    ICommand command;

    public void SetCommand(ICommand newCommand)
    {
        command = newCommand;
    }

    public void ExecuteCommand()
    {
        command.Execute();
    }
}
