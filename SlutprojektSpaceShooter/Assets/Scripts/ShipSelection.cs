using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Att göra nu:
//Välja faction i menyn, beroende på vilken faction ska olika skepp presenteras
//Skapa olika egenskaper till skeppen, olika projektiler, osv 
//Något som urskiljer faction blå mot röd, mer hp men lägre hastighet?
//Skepp egenskaper: 
//Olika fire rate, olika snabba, olika projektiler, 
//Behöver inte ändra någon kod för att välja bland skeppen, bara att skapa två knappar som gör att olika skepp visas i menyn, 
//gör bara att olika knappar returnerar olika ints, se knappar som är skapade sedan innan.
public class ShipSelection : MonoBehaviour
{

    public GameObject[] spaceShipList;
    public int a;
    Vector3 playerSpawnPoint = new Vector3(0f, -4.5f, -3f);
    void Start()
    {
        spaceShipList = new GameObject[transform.childCount];
       
        for (int i = 0; i < transform.childCount; i++)
        {
            spaceShipList[i] = transform.GetChild(i).gameObject;
        }

        //PlayerShipSpawn(spaceShipList[PlayerPrefs.GetInt("SelectedShip")]);
        PlayerShipSpawn(PlayerPrefs.GetInt("SelectedShip"));
    }
    public void PlayerShipSpawn(int whichShipToSpawn)
    {
        //GameObject playerShip
        //Instantiate(playerShip, playerSpawnPoint, Quaternion.identity);
        spaceShipList[whichShipToSpawn].SetActive(true);
    }

    public void SelecedShip(int index)
    {
        
        PlayerPrefs.SetInt("SelectedShip", index);        
    }
    
}
