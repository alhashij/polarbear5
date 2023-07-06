using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public static bool GameOverScreen;
    public GameObject gameOver;

    private void Awake()
    {
        GameOverScreen = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if the game is over and player has collided with a hazard, the game over screen will show up. 
        if (GameOverScreen)
        {
            gameOver.SetActive(true);
            Debug.Log("testforgameover");

        }
    }

    public void LevelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
