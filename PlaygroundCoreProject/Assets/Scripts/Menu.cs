using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Menu : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene("level1");
    }
 
    public void ButtonQuit()
    {
        Application.Quit();
    }
}