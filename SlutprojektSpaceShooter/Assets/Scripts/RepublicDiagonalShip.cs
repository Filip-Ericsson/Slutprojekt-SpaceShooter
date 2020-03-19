﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepublicDiagonalShip : SpaceShip
{
    
 
  
    protected override void Fire()
    {
        GameObject leftLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
        Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);

        leftLazr.GetComponent<DiagonalLazer>().xDir = -0.4f;
    }
    
}