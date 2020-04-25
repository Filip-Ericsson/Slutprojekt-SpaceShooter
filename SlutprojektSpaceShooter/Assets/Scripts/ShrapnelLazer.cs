using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script som ärver från ClusterLazer
class ShrapnelLazer : ClusterLazer
{  
    
    protected Vector3 spawnOffsetUp = new Vector3(0f, 0.5f);
    protected Vector3 spawnOffsetDown = new Vector3(0f, -0.5f);

    protected override void AsteroidCollision(Collision2D collision) //här överskrivs metoden som kallas vid kollision med asteroid
    {
        base.AsteroidCollision(collision); //metodensfunktion i ClusterLazer sparas men utöver det instantieras två ytterligare lasrar 

        GameObject shrapnelUp = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetUp, Quaternion.identity);
        GameObject shrapnelDown = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetDown, Quaternion.identity);
        shrapnelUp.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, 1f);
        shrapnelDown.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, -1f);
    }
    protected override void LazerMovement()
    {
        base.LazerMovement();

        if (transform.position.x > 3f || transform.position.x < -3f) //eftersom två av lasrarna åker längs x-led, måste denna check finnas i detta script
        {
            DestroyLazer();
        }
    }
}
