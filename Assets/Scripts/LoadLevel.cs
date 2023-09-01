using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player is in contact with house");
            //SceneManager.LoadScene("WeatherStation");
        }
    }

    public void enterStation()
    {
        SceneManager.LoadScene("WeatherStation");
    }
}


