using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DiagonalLazer : LazerController
{
    
    Vector3 diagonal = new Vector3(0.5f, 1f);

    public float xDir = 0.6f;
    public float yDir = 1f;

    /*void Update()
    {
        DestroyLazer();
        LazerMovement();
    }*/

    protected override void LazerMovement()
    {
        diagonal = new Vector3(xDir, yDir);
        transform.Translate(diagonal * speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {
            DestroyLazer();
        }

    }
}
