using UnityEngine;


/// <summary>
/// Handles the data related to the decoy objects
/// </summary>
public class DecoyObjects : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] CommandController commandController;

    void Start()
    {
        gameObject.transform.position = new Vector3(1, 0, -29);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.GetIsShooting() == true)
            {
                commandController.SetCommand(new ReverseCommand(player));
                commandController.ExecuteCommand();
                Destroy(gameObject);
            }
        }
    }
}
