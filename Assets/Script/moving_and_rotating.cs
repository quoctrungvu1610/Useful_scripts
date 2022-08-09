using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_and_rotating : MonoBehaviour
{
    Vector3 pos;
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0.01f, 0.02f,0.03f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
        transform.localScale += new Vector3(0,speed,0);
    }
}
