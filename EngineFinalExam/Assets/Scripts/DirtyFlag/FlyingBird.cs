using UnityEngine;

public class FlyingBird : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] CommandController commandController;
    [SerializeField] private Rigidbody rb;

    private bool isDirty;

    void Start()
    {
        gameObject.transform.position = new Vector3(1, 1, -29);
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        if (isDirty == true)
        {
            rb.AddForce(Vector3.right * 0.1f, ForceMode.Impulse);
            isDirty = false;
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.GetIsShooting() == true)
            {
                print("the brid got hit");
                commandController.SetCommand(new ResetCommand(player));
                commandController.ExecuteCommand();
                Destroy(gameObject);
            }
        }
    }

    public void SetIsDirty(bool isObjectDirty)
    {
        isDirty = isObjectDirty;
    }

    public bool GetIsDirty()
    {
        return isDirty;
    }
}
