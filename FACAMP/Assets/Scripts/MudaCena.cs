using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudaCena : MonoBehaviour
{
    public bool m_HasPressKey = true;
    public string m_SceneName = "Menu";
    public KeyCode m_KeyCode = KeyCode.Return;

    void Update()
    {
        if (m_HasPressKey && Input.GetKeyDown(m_KeyCode))
        {
            SceneManager.LoadScene(m_SceneName);
        }

    }

    public void Next(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }



}

