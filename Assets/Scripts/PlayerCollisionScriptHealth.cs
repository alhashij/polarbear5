using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScriptHealth : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Hazard")
        {
            /*PlayerHealth.playerhealth--;
            if (PlayerHealth.playerhealth <= 0)
            {
                PlayerManager.GameOverScreen = true;
            }*/

            PlayerManager.GameOverScreen = true;
            gameObject.SetActive(false);

            Debug.Log("incontact");

        }
    }
}
