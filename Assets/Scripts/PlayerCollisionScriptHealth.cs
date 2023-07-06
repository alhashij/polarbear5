using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScriptHealth : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Hazard")
        {

            /* //displays the game over screen when player comes into contact with the hazard
             PlayerManager.GameOverScreen = true;
             //disables player from moving once at game over screen,
             //it disables the full screen and puts the canvas game over screen only
                 gameObject.SetActive(false);
             Debug.Log("Test");
            */


            PlayerHealth.maxplayerhealth--;
            if (PlayerHealth.maxplayerhealth <= 0)
            {
                PlayerManager.GameOverScreen = true;
                gameObject.SetActive(false);

                Debug.Log("players health at 0 now game over");


            }
        }
    }
}
