using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggertoLoadScene : MonoBehaviour
{
    
    void Update()
    {

        if (Input.GetButtonDown("Use"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


 
}
