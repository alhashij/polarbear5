using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    
    [Range(1, 10)]
    [SerializeField] private float speed = 5f;

    [Range(1, 10)]
    [SerializeField] private float durationtime = 3f;


    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, durationtime);
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed; //bullet goes forward,the object moving in the upward direction with the given speed.

    }



}
