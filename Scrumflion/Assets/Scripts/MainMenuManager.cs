using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options Menu");
    }
    

    public void QuitGame()
    {
       
        Application.Quit();
    }
}
