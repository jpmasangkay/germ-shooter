using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Reset : MonoBehaviour
{
    public GameObject GameOver;

    void Start()
    {
        // Initialize if needed
    }

    void Update()
    {
        // Check for "Fire1" button press (usually left mouse button or Ctrl)
        if (Input.GetButtonDown("Fire1"))
        {
            QuitGame();
        }
    }

    void QuitGame()
    {
        // If we're in the Unity editor, stop the play mode
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        // Quit the game in a built version
        Application.Quit();
#endif
    }
}
