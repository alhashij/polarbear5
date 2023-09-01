using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InTrigger : MonoBehaviour
{
    /*
        public GameObject button;

        public GameObject buttonAndTextDrawer;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void OnTriggerEnter2D (Collider2D collision)
        {

            Debug.Log("Player is in weatherstation collider");
            if (collision.gameObject == button)
            {
                Debug.Log("button showed up");
                button.SetActive(true);
            }

        }

        public void OnTriggerExit2D(Collider2D collision)
        {
            button.SetActive(false);
        }
        public Canvas buttonCanvas; // Reference to the canvas containing the button
        public GameObject button; // Reference to the button within the canvas
    */


    public Canvas buttonCanvas; // Reference to the canvas containing the button
    public GameObject button; // Reference to the button within the canvas
    private void Start()
    {
        buttonCanvas.enabled = false; // Disable the canvas initially
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player" + collision.tag);
        if (collision.CompareTag("Player"))
        {
            Debug.Log("player in collision");
            buttonCanvas.enabled = true; // Enable the canvas when the player enters the trigger area
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            buttonCanvas.enabled = false; // Disable the canvas when the player exits the trigger area
        }
    }
}




