using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ett script som laddar scenen för menyn och stänger även applikationen om användaren trycker på quit knappen
public class Menue : MonoBehaviour
{
    

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
