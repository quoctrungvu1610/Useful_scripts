using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_each_loop : MonoBehaviour
{
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject o in gameObjects)
        {
            o.SetActive(false);
            o.SetActive(true);
            o.transform.Translate(0.1f, 0, 0);        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
