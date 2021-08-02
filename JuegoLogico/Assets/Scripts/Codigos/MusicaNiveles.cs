using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaNiveles : MonoBehaviour
{
    private MusicaNiveles instance;
    public MusicaNiveles Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awanke()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
