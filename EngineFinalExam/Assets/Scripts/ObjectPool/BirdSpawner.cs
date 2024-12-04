using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    [SerializeField] private BirdPool spawnerPool;
    [SerializeField] private Transform spawnPos;
    

    // Update is called once per frame
    void Update()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("SPAWNING THE OBJECT");
            GameObject bird = spawnerPool.GetObject();
        }
    }
}
