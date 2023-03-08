using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor; 
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartButton_Click()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitButton_Click()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
