using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string start;
    public string menu;
    public string credit;
    public void StartGame()
    {
        SceneManager.LoadScene(start);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(menu);
    }

    public void Credit()
    {
        SceneManager.LoadScene(credit);
    }

    public void Mulai()
    {
        Destroy(gameObject);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
