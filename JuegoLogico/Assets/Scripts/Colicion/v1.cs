using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class v1 : MonoBehaviour
{
    public GameObject mensaje;
    public GameObject botonQuitar;
    // Start is called before the first frame update
    void Start()
    {
        mensaje.SetActive(false);
        botonQuitar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensaje.SetActive(true);
            botonQuitar.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensaje.SetActive(false);
            botonQuitar.SetActive(false);
        }
    }

}
    
