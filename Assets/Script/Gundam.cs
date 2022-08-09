using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Gundam 
{
    public float height;
    public string type;
    public string scale;
    public string name;
    public Gundam()
    {
        Debug.Log("Gundam constructor create");
    }
    public Gundam(float height)
    {
        this.height = height;
        Debug.Log("Gundam constructor with height create");

    }
    void Shoot()
    {
        Debug.Log("Shoot beam");
    }
    void Transform()
    {
        Debug.Log("Transform to core fighter");
    }
    public void GundamDetail()
    {
        Debug.Log("name : "+ name + "\n" + "type : " + type + "\n" + "scale : " + scale + "\n" + "height : " + height + "\n");

    }
}
