using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepublicDiagonalShip : SpaceShip
{
    
 //denna kod som ärver av spaceShip förändrar värdet på DiagonalLazer så att den vänstra lasern färdas i en annan rikting än den högra
  
    protected override void Fire()
    {
        Debug.Log("diagonalshipFire");
        GameObject leftLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
        Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);

        leftLazr.GetComponent<DiagonalLazer>().xDir = -0.6f;
    }
    
}