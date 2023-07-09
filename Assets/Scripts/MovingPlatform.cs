using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform startPoint; // Starting position of the platform
    public Transform endPoint; // Ending position of the platform
    public float moveSpeed = 2f; // Speed of the platform
    public float moveDistance = 10f; // Distance the platform moves

    private Vector3 initialPosition; // Initial position of the platform
    private Vector3 currentTarget; // Current target position of the platform
    private bool movingToEnd = true; // Flag indicating the direction of movement

    private void Start()
    {
        initialPosition = transform.position; // Store the initial position of the platform
        currentTarget = endPoint.position; // Set the initial target to the end position
    }

    private void Update()
    {
        // Calculate the distance between the current position and the initial position
        float distanceToInitial = Vector3.Distance(transform.position, initialPosition);

        // Check if the platform has reached the maximum move distance
        if (distanceToInitial >= moveDistance)
        {
            // Switch the direction of movement
            movingToEnd = !movingToEnd;

            // Set the new current target based on the direction
            if (movingToEnd)
            {
                currentTarget = endPoint.position;
            }
            else
            {
                currentTarget = startPoint.position;
            }
        }

        // Move the platform towards the current target position
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, moveSpeed * Time.deltaTime);
    }
}