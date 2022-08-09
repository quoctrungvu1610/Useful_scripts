using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour

{
    public bool isDisplay = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Enemy")
        {
            
            //Destroy(collision.gameObject);
            isDisplay = true;
            if(isDisplay == true)
            {
                DisappearComponent(collision);
                isDisplay = false;
            }
        }
    }
    void DisappearComponent(Collision other)
    {
        //other.gameObject.GetComponent<Renderer>().material.color = Color.green;
        other.gameObject.SetActive(false);
    }
}
