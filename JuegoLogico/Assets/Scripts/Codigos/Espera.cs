using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espera : MonoBehaviour
{
    public GameObject img;
    public GameObject Continuar;
    public GameObject Regresar;
    public GameObject Pausa;

    void Start()
    {
        img.SetActive(false);
        Continuar.SetActive(false);
        Regresar.SetActive(false);
    }

    public void Hub()
    {
        img.SetActive(true);
        Continuar.SetActive(true);
        Regresar.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        img.SetActive(false);
        Continuar.SetActive(false);
        Regresar.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
    }

}
