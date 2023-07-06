using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScriptHealth : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Hazard")
        {
            PlayerManager.GameOverScreen = true;
            Debug.Log("Test");
        }
    }
}
