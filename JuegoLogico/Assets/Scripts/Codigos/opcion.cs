using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opcion : MonoBehaviour
{
    public GameObject img;
    public GameObject botonQuitar;
    public GameObject botonSiguiente;
    public GameObject botonAntes;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        botonSiguiente.SetActive(false);
        botonAntes.SetActive(false);
        botonQuitar.SetActive(false);

    }

    public void ObcionAbrir()
    {
        img.SetActive(true);
        botonSiguiente.SetActive(true);
        botonAntes.SetActive(true);
        botonQuitar.SetActive(true);
    }
    public void ObcionCerrar()
    {
        img.SetActive(false);
        botonSiguiente.SetActive(false);
        botonAntes.SetActive(false);
        botonQuitar.SetActive(false);
    }
}
