using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static int maxplayerhealth = 3;

    public int health;

    public GameObject gameOver, heart1, heart2, heart3;


    //sprites
    //public Image[] threehearts; //array for the sprite
    //public Sprite Heart;
    //public Sprite noHeart;


    void Start()
    {
        maxplayerhealth = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        
    }

    private void Update()
    {
        switch (maxplayerhealth)
        {

            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                
                break;

            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                
                Debug.Log("Test");
                break;

            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
               
                Debug.Log("Test for 2 missing hearts");
                break;

            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                Debug.Log("Test for all 3 hearts to be gone");
                break;


            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                //gameOver.gameObject.SetActive(false);
                Debug.Log("Test 3 for final heart");
                Time.timeScale = 0;
                break;
        }
    }
    private void Awake()
    {
        maxplayerhealth = 3; //everytime scene restarts, the three hearts will show up full. It basically resets the hearts everytime a player retrys
    }


    // Update is called once per frame
    /*void Update()
    {
        //when the player loses a heart(takes damage)
        foreach (Image img in threehearts) //hearts array  
        {
            img.sprite = noHeart; //image sprite is equal to no heart
        }
        for (int i = 0; i < maxplayerhealth; i++)
        {
            threehearts[i].sprite = Heart; //image sprite is equal to full heart
        }
    }*/
}
