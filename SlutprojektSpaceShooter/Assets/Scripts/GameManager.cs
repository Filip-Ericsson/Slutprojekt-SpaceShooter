using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject star;
    public GameObject player;
    void Start()
    {
        int i = 0;
        while (i < 100)
        {
            Instantiate(star);

            i++;
        }
    }
    public float Matrix = 10f;
    public void EndGame()
    {
        FindObjectOfType<PlayerController>().enabled = false;
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        //en sekund före komando
        Time.timeScale = 1f / Matrix;
        Time.fixedDeltaTime = Time.fixedDeltaTime / Matrix;


        yield return new WaitForSeconds(1f / Matrix);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * Matrix;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //en sekund efter komando
    }

}
