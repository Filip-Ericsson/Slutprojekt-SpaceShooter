using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepublicAlternatingShip : RepublicDiagonalShip
{
    // Start is called before the first frame update
    bool alternatingFire = false;
    protected override void Fire()
    {
        GameObject leftLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
        GameObject rightLazr = Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
        
        if (alternatingFire == true)
        {
            /*Debug.Log("Fire!");
            base.Fire();*/
            leftLazr.GetComponent<DiagonalLazer>().xDir = -0.2f;
            leftLazr.GetComponent<DiagonalLazer>().yDir = 3f;
            rightLazr.GetComponent<DiagonalLazer>().xDir = 0.2f;
            rightLazr.GetComponent<DiagonalLazer>().yDir = 3f;

            alternatingFire = false;
        }
        else
        {
            base.Fire();
            alternatingFire = true;
        }
        
    }

    
}
