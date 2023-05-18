using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePistols : MonoBehaviour
{
    private Vector3 MousePosition;
    private Camera Cam;


    // Start is called before the first frame update
    void Start()
    {
        //Cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
       /* //setting the vector 3 to the input.mouseposition which is the current mouseposition on screen
        MousePosition = Cam.ScreenToWorldPoint(Input.mousePosition);

        //
        Vector3 rotation = MousePosition - transform.position;

        //how to create a rotation
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
       */

        Vector3 MousePosition = Input.mousePosition;
        MousePosition.z = 10;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);

        Vector3 direction = new Vector2(MousePosition.x - transform.position.x, MousePosition.y - transform.position.y);

        transform.right = direction;    



    }
}
