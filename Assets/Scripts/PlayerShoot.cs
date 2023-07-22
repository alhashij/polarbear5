using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 10f;

    [Range(1, 10)]
    [SerializeField] private float durationTime = 3f;

    private Vector2 shootDirection;

    void Start()
    {
        Destroy(gameObject, durationTime);

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        shootDirection = (mousePosition - transform.position).normalized;

        Debug.Log("shootDirection: " + shootDirection);
    }

    private void Update()
    {
        transform.Translate(shootDirection.normalized * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}



