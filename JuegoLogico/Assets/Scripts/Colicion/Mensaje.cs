using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensaje : MonoBehaviour
{
    public GameObject mensaje;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mensaje")
        {
            Debug.Log("funciona!!!!!!!!!!!!");
        }
    }

    /*void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Mensaje")
        {
            Debug.Log("funciona!!!!!!!!!!!!");
        }
    }*/
}
