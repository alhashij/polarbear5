using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int playerhealth = 3;

    public Image[] threehearts;

    public Sprite Heart;

    public Sprite noHeart;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when the player loses a heart(takes damage)
        foreach (Image img in threehearts)
        {
            img.sprite = noHeart;
        }
        for (int i = 0; i < playerhealth; i++)
        {
            threehearts[i].sprite = Heart;
        }
    }
}
