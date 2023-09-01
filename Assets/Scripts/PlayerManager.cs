using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public static bool GameOverScreen;
    public GameObject gameOver;

    public static Vector2 lastCheckpointPosition = new Vector2 (-30, 16);

    private void Awake()
    {
        GameOverScreen = false;
        //returns that game object
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckpointPosition;

        Debug.Log("player is in contact with checkpoint position");
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
            Time.timeScale = 0;
            gameOver.SetActive(true);
            Debug.Log("testforgameover");

        }
        else
        {
            GameOverScreen = false;
            Time.timeScale = 1;
        }
    }

    public void LevelReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
