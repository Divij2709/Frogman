using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Manual_Level");
        
        
    }
    
    public void ExitGame()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("StartScene");
        
    }
    
    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
                
        #if UNITY_STANDALONE
                Application.Quit();
        #endif
        
    }
}
