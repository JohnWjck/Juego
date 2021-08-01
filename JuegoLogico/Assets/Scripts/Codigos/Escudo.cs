using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    public GameObject img;
    public GameObject botonQuitar;
    public GameObject botonSiguiente;
    public GameObject botonAntes;
    public GameObject botonVer;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        botonSiguiente.SetActive(false);
        botonAntes.SetActive(false);
        botonQuitar.SetActive(false);
        //botonVer.SetActive(false);
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
        Debug.Log("funciona!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
