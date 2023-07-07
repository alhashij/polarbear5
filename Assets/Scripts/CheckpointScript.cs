using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private Vector3 checkpointPosition; // Store the checkpoint position

    public void SetPlayerCheckpoint(PlayerCollisionScriptHealth player)
    {
        player.SetCheckpoint(checkpointPosition); // Set the player's checkpoint position
    }

    private void Start()
    {
        checkpointPosition = transform.position; // Set the initial checkpoint position to the checkpoint's position
    }
}
