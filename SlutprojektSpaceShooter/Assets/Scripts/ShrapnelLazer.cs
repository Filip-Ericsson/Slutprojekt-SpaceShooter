using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ShrapnelLazer : ClusterLazer
{

    


    protected Vector3 spawnOffsetUp = new Vector3(0f, 0.5f);
    protected Vector3 spawnOffsetDown = new Vector3(0f, -0.5f);

    protected override void AsteroidCollision(Collision2D collision)
    {
        base.AsteroidCollision(collision);

        GameObject shrapnelUp = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetUp, Quaternion.identity);
        GameObject shrapnelDown = Instantiate(Shrapnel, collision.gameObject.transform.position + spawnOffsetDown, Quaternion.identity);
        shrapnelUp.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, 1f);
        shrapnelDown.GetComponent<ShrapnelLazer>().lazerDir = new Vector3(0f, -1f);
    }
    protected override void LazerMovement()
    {
        base.LazerMovement();

        if (transform.position.x > 3f || transform.position.x < -3f)
        {
            DestroyLazer();
        }
    }
}
