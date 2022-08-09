using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_loader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("HI");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //LoadLevel();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            RestartLevel();
        }

    }
    void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
