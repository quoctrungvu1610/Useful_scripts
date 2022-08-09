using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_object : MonoBehaviour
    
{
    GameObject findObject;
    // Start is called before the first frame update
    void Start()
    {
        findObject = GameObject.FindWithTag("tagchild2");
        Destroy(findObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
