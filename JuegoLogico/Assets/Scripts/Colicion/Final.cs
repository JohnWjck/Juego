using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject img;
    public GameObject menu;
    public GameObject sigiente;
    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        menu.SetActive(false);
        sigiente.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            img.SetActive(true);
            menu.SetActive(true);
            sigiente.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            img.SetActive(false);
            menu.SetActive(false);
            sigiente.SetActive(false);
        }
    }
}
