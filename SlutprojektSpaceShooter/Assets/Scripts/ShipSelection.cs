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
    
    
    void Start()
    {
        spaceShipList = new GameObject[transform.childCount];
       
        //Alla skepp finns som barn under ett tomt gameObject i hirarkin, när användaren väljer ett skepp genom att trycka på en knapp i scenen 
        for (int i = 0; i < transform.childCount; i++)
        {
            spaceShipList[i] = transform.GetChild(i).gameObject;
        }
        
        PlayerShipSpawn(PlayerPrefs.GetInt("SelectedShip")); //för att värdet ska färdas mellan scener använder jag PlayerPrefs, lånade detta från stackOverflow så är inte helt säker på mekaniken bakom, men det funkar
    }
    public void PlayerShipSpawn(int whichShipToSpawn) //denna metod aktiverar det skepp som användaren valde i menyn i föregående scen
    {        
        spaceShipList[whichShipToSpawn].SetActive(true);
    }

    public void SelecedShip(int index)
    {
        
        PlayerPrefs.SetInt("SelectedShip", index);        
    }
    
}
