using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour
{
    public GameObject img;
    public GameObject Btn1;
    public GameObject Btn2;
    public GameObject Salir;
    public GameObject Llave;
    public GameObject Piedra;
    public GameObject Verde1;
    public GameObject Verde2;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        Btn1.SetActive(false);
        Btn2.SetActive(false);
        Salir.SetActive(false);
        Llave.SetActive(false);
        Verde1.SetActive(false);
        Verde2.SetActive(false);

    }
    
    public void respuesta1()
    {
        Btn2.SetActive(true);
        Verde1.SetActive(true);

    }

    public void respuesta2()
    {
        Piedra.SetActive(false);
        img.SetActive(false);
        Btn1.SetActive(false);
        Btn2.SetActive(false);
        Salir.SetActive(false);
        Llave.SetActive(false);
        Verde2.SetActive(true);
    }

    public void llaveFinal()
    {
        img.SetActive(true);
        Btn1.SetActive(true);
        Salir.SetActive(true);
       // Llave.SetActive(false);
    }

    public void Cerrar()
    {
        img.SetActive(false);
        Btn1.SetActive(false);
        Btn2.SetActive(false);
        Salir.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Llave.SetActive(true);
            Debug.Log("Entro!!!!!!!!!!!!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Llave.SetActive(false);
        }
    }
}
