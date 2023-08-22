using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScriptHealth : MonoBehaviour
{
    private bool isColliding = false;
    private bool canTakeDamage = true; // Add flag to control damage
    private Vector3 spawnPosition; // Store the spawn position
    private Vector3 checkpointPosition; // Store the checkpoint position
    private Rigidbody2D rb; // Reference to the player's Rigidbody2D component

    
    private void Start()
    {
        spawnPosition = transform.position; // Store the initial spawn position
        checkpointPosition = spawnPosition; // Set the initial checkpoint position to the spawn position
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }

    private void OnCollisionEnter2D(Collision2D collision) //detects collision
    {
        //if (collision.transform.CompareTag("Hazard") && !isColliding && canTakeDamage)
            if ((collision.transform.CompareTag("Hazard") || collision.transform.CompareTag("Enemy")) && !isColliding && canTakeDamage) //two tags

        {
            isColliding = true;
            canTakeDamage = false; // Disable damage temporarily

            PlayerHealth.maxplayerhealth--;

            if (PlayerHealth.maxplayerhealth <= 0)
            {
                //PlayerHealth.gameObject.heart1.SetActive(false);
                PlayerManager.GameOverScreen = true;
                //gameObject.SetActive(false);

                Debug.Log("Player's health is now 0. Game over.");
            }
            else
            {
                StartCoroutine(EnableDamage()); // Enable damage after a delay
                //StartCoroutine(DisableMovementForSeconds(2f)); // Disable player movement for 2 seconds
                //ResetToCheckpointPosition(); // Reset the player to the checkpoint position
            }
        }
    }

    private IEnumerator EnableDamage()
    {
        yield return new WaitForSeconds(1f); // Adjust the delay as needed
        canTakeDamage = true; // Enable damage
    }

    /*private IEnumerator DisableMovementForSeconds(float seconds)
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll; // Freeze player movement
        yield return new WaitForSeconds(seconds);
        rb.constraints = RigidbodyConstraints2D.None; // Unfreeze player movement
    }*/

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Hazard"))
        {
            isColliding = false;
        }
    }

    /*private void ResetToCheckpointPosition()
    {
        rb.velocity = Vector2.zero; // Stop the player's current velocity
        transform.position = checkpointPosition; // Reset the player position to the checkpoint position
    }

    public void SetCheckpoint(Vector3 position)
    {
        checkpointPosition = position; // Set the checkpoint position to the provided position
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
      // if (collision.CompareTag("Checkpoint"))
      //  {
            //CheckpointScript checkpoint = collision.GetComponent<CheckpointScript>();
        //    if (checkpoint != null)
           // {
              //  checkpoint.SetPlayerCheckpoint(this); // Set the player's checkpoint position
            //}
        */
    }

