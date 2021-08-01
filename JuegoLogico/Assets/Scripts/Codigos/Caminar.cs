using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip pasto, piso;
    public LayerMask PastoLayer, PisoLayer;
    public Transform checkPoint;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void SoundWalk()
    {
      audio.Play(); 
    }
}
