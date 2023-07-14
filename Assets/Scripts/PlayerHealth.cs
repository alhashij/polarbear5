using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static int maxplayerhealth = 3;

    public Image[] threehearts;

    public Sprite Heart;

    public Sprite noHeart;



    private void Awake()
    {
        maxplayerhealth = 3; //everytime scene restarts, the three hearts will show up full. It basically resets the hearts everytime a player retrys
    }


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
        for (int i = 0; i < maxplayerhealth; i++)
        {
            threehearts[i].sprite = Heart;
        }
    }
}
