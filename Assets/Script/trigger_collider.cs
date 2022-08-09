using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_collider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;

    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
}
