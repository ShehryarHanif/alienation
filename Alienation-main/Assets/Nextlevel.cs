using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{

    public GameObject present;
    public GameObject flyer;
    public GameObject book;
    public int[] objects;
    public int counter = 0;
    public float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        objects = new int [3];
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (present.GetComponent<Interactable_map_object>().is_activated == true)
        {
            objects[0] = 1;
        }
        if (flyer.GetComponent<Interactable_map_object>().is_activated == true)
        {
            objects[1] = 1;
        }
        if (book.GetComponent<Interactable_map_object>().is_activated == true)
        {
            objects[2] = 1;
        }
        counter = 0;
        for (int x = 0; x < 3; x++)
        {
            if (objects[x] == 1)
            {
                counter++;

            }
        }
        if (counter == 3)
        {
            time = time + Time.fixedDeltaTime;
            if (time > 20)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(sceneBuildIndex: 7);
            }
        }
    }
}
