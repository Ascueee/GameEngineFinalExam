using UnityEngine;
using System.Collections.Generic;

public class BirdPool : MonoBehaviour
{
    [SerializeField] private GameObject spawnObj;
    [SerializeField] private int poolSize;

    private List<GameObject> gameObjects = new List<GameObject>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bird = Instantiate(spawnObj, new Vector3(0,0, -29), Quaternion.identity);
            bird.SetActive(false);
            gameObjects.Add(bird);
        }
    }
    
    
    public GameObject GetObject()
    {
        foreach (var obj in gameObjects)
        {
            if (obj.activeInHierarchy == false)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        GameObject newObj = Instantiate(spawnObj);
        newObj.SetActive(true);
        gameObjects.Add(newObj);
        return newObj;
    }

    public void ReturnObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
