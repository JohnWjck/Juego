using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarImg : MonoBehaviour
{
    private GameObject[] cambiarImagen;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        cambiarImagen = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            cambiarImagen[i] = transform.GetChild(i).gameObject;
        foreach (GameObject objX in cambiarImagen)
            objX.SetActive(false);

        if (cambiarImagen[index])
            cambiarImagen[index].SetActive(true);

    }

    public void btnLeft()
    {
        cambiarImagen[index].SetActive(false);
        index--;
        if (index < 0)
            index = cambiarImagen.Length - 1;
        cambiarImagen[index].SetActive(true);
    }

    public void btnRight()
    {
        cambiarImagen[index].SetActive(false);
        index++;
        if (index == cambiarImagen.Length)
            index = 0;
        cambiarImagen[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}