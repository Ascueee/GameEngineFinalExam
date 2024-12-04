using UnityEngine;

public class ReverseCommand : ICommand
{
    private PlayerController player;
    public ReverseCommand(PlayerController player)
    {
        this.player = player;
    }
    
    public void Execute()
    {
        player.ReverseInput();
    }
}
