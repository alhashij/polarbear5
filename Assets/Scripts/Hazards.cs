using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;


public class Hazards : MonoBehaviour
{


    public int hazard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        //reloads scene when player collides into object when using static UnityEngine.SceneManagement.SceneManager
        if (collision.CompareTag("Player"))
        {
            LoadScene(GetActiveScene().buildIndex);

        }

    }
}

