using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeted_calling : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ball;
    void Start()
    {
        InvokeRepeating("RandomBall", 5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CancelInvoke("RandomBall");
        }
    }
    void RandomBall()
    {
        int randomNumber = Random.Range(0, ball.Length);
        Instantiate(ball[randomNumber], transform.position, Quaternion.identity);
    }
}
