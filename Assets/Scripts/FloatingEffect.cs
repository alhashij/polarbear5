using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingEffect : MonoBehaviour
{
    public float floatHeight = 0.5f;  // Adjust this to control the height of floating.
    public float floatSpeed = 1.0f;   // Adjust this to control the speed of floating.

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new Y position based on a sine wave to create the floating effect.
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the object's position.
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
