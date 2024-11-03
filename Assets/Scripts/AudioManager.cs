using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip introMusic;
    public AudioClip normalMusic;
    
 
    void Start()
    {
        PlayMusicBasedOnScene();

    }

    private void PlayMusicBasedOnScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.buildIndex == 0)
        {
            if (!source.isPlaying || source.clip != introMusic)
            {
                source.clip = introMusic;
                source.Play();
            }
        }
        else if (currentScene.buildIndex == 1)
        {
            if (!source.isPlaying || source.clip != normalMusic)
            {
                source.clip = normalMusic;
                source.Play();
            }
        }
    }

   
   
}
