using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gundam_class : MonoBehaviour
{
    public Gundam gundam;
    // Start is called before the first frame update
    void Start()
    {

        //Gundam zeta = new Gundam(2.5f);
        //zeta.name = "Zeta gundam";
        //zeta.scale = "1/144";
        //zeta.type = "HGUC";
        gundam.GundamDetail();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
