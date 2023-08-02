using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{


        void OnCollisionEnter(Collision otherObj)
        {
            if (CompareTag("Player"))
            {
                Destroy(gameObject, .5f);
            }
        }

    }
