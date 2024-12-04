using UnityEngine;

public class ResetCommand : ICommand
{
    private PlayerController player;
    public ResetCommand(PlayerController player)
    {
        this.player = player;
    }
    
    public void Execute()
    {
        player.DefaultInput();
    }
}
