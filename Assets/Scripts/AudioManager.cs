using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip introMusic;
    public AudioClip normalMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        source.PlayOneShot(introMusic);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(normalMusic);
        }
        
    }
}
