using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float startingX;
    int dir = 1;

    public float speed = 0.9f;
    public float range = 5f;


    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime *dir); //moves enemy right
        if (transform.position.x < startingX || transform.position.x > startingX + range) // if the position of the enemy is is less than starting point position or range
            dir *= -1;
    }
}
