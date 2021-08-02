using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leer : MonoBehaviour
{
    public GameObject img;
    public GameObject botonQuitar;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        botonQuitar.SetActive(false);

    }
    public void LeerAbrir()
    {
        img.SetActive(true);
        botonQuitar.SetActive(true);
    }
    public void LeerCerrar()
    {
        img.SetActive(false);
        botonQuitar.SetActive(false);
    }
}
