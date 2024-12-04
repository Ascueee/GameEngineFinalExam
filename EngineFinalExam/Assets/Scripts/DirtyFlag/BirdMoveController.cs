using UnityEngine;

public class BirdMoveController : MonoBehaviour
{
    [SerializeField] private FlyingBird bird;
    [SerializeField] private float interval;

    private float time;
    
     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = interval;
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.GetIsDirty() == false)
        {
            //Invoke(nameof(SetFlag), interval);
            CountDown();
        }
    }

    void CountDown()
    {   
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SetFlag();

        }
    }

    void SetFlag()
    {
        print("setting the flag");
        bird.SetIsDirty(true);
        time = interval;
    }
}
