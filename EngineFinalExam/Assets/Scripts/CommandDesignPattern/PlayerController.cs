using UnityEngine;

/// <summary>
/// Handles the player data
/// </summary>
public class PlayerController : MonoBehaviour
{
    private bool isReverseAiming = false;
    [SerializeField] private GameObject hitBox;
    [SerializeField] private float speed;
    private bool isShooting;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitBox.transform.position = new Vector3(0, 0, -29);
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        MoveAimCursor();
    }

    //uses movement input to move cursor
    void MoveAimCursor()
    {

        if (isReverseAiming == false)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.up * speed, ForceMode.Force);
            }
        
            if (Input.GetKeyDown(KeyCode.S))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.up * -speed, ForceMode.Force);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Force);
            }
        
            if (Input.GetKeyDown(KeyCode.A))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.right * -speed, ForceMode.Force);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.up * -speed, ForceMode.Force);
            }
        
            if (Input.GetKeyDown(KeyCode.S))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.up * speed, ForceMode.Force);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.right * -speed, ForceMode.Force);
            }
        
            if (Input.GetKeyDown(KeyCode.A))
            {
                hitBox.GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Force);
            }
        }
 
    }

    //Shoots a raycast in the forward direction
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("SHOOT");
            isShooting = true;
        }
    }


    public void SetIsReverseAim(bool newState)
    {
        isReverseAiming = newState;
    }

    public bool GetIsReverseAiming()
    {
        return isReverseAiming;
    }
    
    public bool GetIsShooting()
    {
        return isShooting;
    }
    public void ReverseInput()
    {
        print("Reverse the input of the player");
        isReverseAiming = true;
    }

    public void DefaultInput()
    {
        print("Setting Input back to default");
        isReverseAiming = false;
    }
}
