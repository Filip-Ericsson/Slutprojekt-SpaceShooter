using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ClusterLazer : LazerController
{
    
    public GameObject Shrapnel;
    protected Vector3 spawnOffsetRight = new Vector3(0.5f,0f);
    protected Vector3 spawnOffsetLeft = new Vector3(-0.5f, 0f);

    protected override void AsteroidCollision(Collision2D collision)
    {
        base.AsteroidCollision(collision);

        GameObject shrapnelLeft = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetRight, Quaternion.Euler(0f, 0f, 90f));
        GameObject shrapnelRight = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetLeft, Quaternion.Euler(0f, 0f, 90f));


        shrapnelLeft.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, -1f);
        shrapnelRight.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, 1f);
    }
    
}
