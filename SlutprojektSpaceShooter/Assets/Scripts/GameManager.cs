using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Detta script sköter bytet och omstart av scener
//Detta är återanvänt från första spaceShooter projektet vi gjorde för ett år sedan
public class GameManager : MonoBehaviour
{
    public GameObject star;
    public GameObject player;
    void Start() //när spelet startar instantieras 100 stjärnor som färdas upp och ned för skärmen
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
        FindObjectOfType<PlayerController>().enabled = false; //stänger av spelarens möjlighet att röra sig i spelet när man dör
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        //en sekund före komando
        Time.timeScale = 1f / Matrix; //timeScalen saktar in för att ge en slowmotion effekt
        Time.fixedDeltaTime = Time.fixedDeltaTime / Matrix;


        yield return new WaitForSeconds(1f / Matrix); //senarelägger nästkommande kodrader en viss tidsperiod, detta fallet en sekund

        //en sekund efter komando
        Time.timeScale = 1f; //återställer timeScalen
        Time.fixedDeltaTime = Time.fixedDeltaTime * Matrix;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reloadar den aktiva scenen

        
    }

}
