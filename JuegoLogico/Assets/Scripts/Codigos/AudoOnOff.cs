using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudoOnOff : MonoBehaviour
{
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void musicaOn()
    {
        musica.Play();
    }
    public void musicaOff()
    {
        musica.Stop();
    }
}
