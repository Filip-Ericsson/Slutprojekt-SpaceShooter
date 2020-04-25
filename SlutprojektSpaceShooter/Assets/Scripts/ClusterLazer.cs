using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//detta script kontrolerar lasern som dels ärver från klassen LazerController, och vad som händer med lasrar som kolliderar med objekt i scenen
class ClusterLazer : LazerController
{
    
    public GameObject Shrapnel;
    //eftersom två objekt instantieras när lasern kolliderar med en asteroid på den plats där kollisionen skedde måste instantieringen ske med en liten offset för att de inte  ska kollidera med asteroiden.
    protected Vector3 spawnOffsetRight = new Vector3(0.5f,0f);
    protected Vector3 spawnOffsetLeft = new Vector3(-0.5f, 0f);

    protected override void AsteroidCollision(Collision2D collision) //överskrivning av basmetoden som kallas när en laser kolliderar med en asteroid.
    {
        base.AsteroidCollision(collision); //basfunktionen sparas men utöver det instantieras även två nya lasrar vid platsen i scenen där kollisionen skedde

        GameObject shrapnelLeft = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetRight, Quaternion.Euler(0f, 0f, 90f)); //lasrarna instantieras på platsen vid kollisionen och med en 90 grades vinkel.
        GameObject shrapnelRight = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetLeft, Quaternion.Euler(0f, 0f, 90f));


        shrapnelLeft.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, -1f); //eftersom de nya lasrarna instantieras med en 90 graders vinkel 
        shrapnelRight.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, 1f);// ökar/minskar man värdet på y-axeln i vector3 som kontrolerar vilken rikting objektet färdas
    }
    
}
