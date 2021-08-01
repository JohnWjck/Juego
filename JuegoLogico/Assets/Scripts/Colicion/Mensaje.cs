using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensaje : MonoBehaviour
{
    public GameObject img;
    public GameObject botonQuitar;
    public GameObject botonSiguiente;
    public GameObject botonAntes;
    public GameObject botonVer;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        botonSiguiente.SetActive(false);
        botonAntes.SetActive(false);
        botonQuitar.SetActive(false);
        botonVer.SetActive(false);
    }

    public void btnStop()
    {
        img.SetActive(false);
        botonSiguiente.SetActive(false);
        botonAntes.SetActive(false);
        botonQuitar.SetActive(false);
    }

    public void btnVer()
    {
        img.SetActive(true);
        botonSiguiente.SetActive(true);
        botonAntes.SetActive(true);
        botonQuitar.SetActive(true);
        botonVer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            botonVer.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            botonVer.SetActive(false);
        }
    }



    /*public GameObject mensaje;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("funciona!!!!!!!!!!!!");
        }
    }*/

    /*void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Mensaje")
        {
            Debug.Log("funciona!!!!!!!!!!!!");
        }
    }*/
}
