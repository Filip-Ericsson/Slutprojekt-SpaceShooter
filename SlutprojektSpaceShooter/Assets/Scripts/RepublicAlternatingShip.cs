using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepublicAlternatingShip : RepublicDiagonalShip
{
    // Start is called before the first frame update
    bool alternatingFire;
    protected override void Fire()
    {
        if(alternatingFire == true)
        {
            base.Fire();
            alternatingFire = false;
        }
        else
        {
            GameObject leftLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
            GameObject rightLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
            leftLazr.GetComponent<DiagonalLazer>().xDir = -0.8f;
            rightLazr.GetComponent<DiagonalLazer>().xDir = 0.7f;
            alternatingFire = true;
        }
        
    }

    
}
