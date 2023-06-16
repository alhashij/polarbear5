using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    public GameObject pelletPrefab; // Prefab of the pellet object
    public Transform muzzlePoint; // Point pellet spawning point
    public float pelletSpeed = 10f; // Speed 
    public float fireRate = 0.2f; // Time delay between shots

    private float nextFireTime; // Time of the next allowed shot

    private void Update()
    {
        Vector3 MousePosition = Input.mousePosition;
        MousePosition.z = 10;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);

        Vector3 direction = new Vector2(MousePosition.x - transform.position.x, MousePosition.y - transform.position.y);

        transform.right = direction;

        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void Shoot()
    {
        GameObject pellet = Instantiate(pelletPrefab, muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody pelletRigidbody = pellet.GetComponent<Rigidbody>();

        if (pelletRigidbody != null)
        {
            pelletRigidbody.AddForce(muzzlePoint.forward * pelletSpeed, ForceMode.VelocityChange);
        }
        else
        {
            Debug.LogError("The pellet prefab does not have a Rigidbody component!");
        }
    }
}

