using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DiagonalLazer : LazerController
{
    
    Vector3 diagonal = new Vector3(0.5f, 1f);

    public int xDir = 1;

    void Update()
    {
        DestroyLazer();
        LazerMovement();
    }

    protected override void LazerMovement()
    {
        
        transform.Translate(xDir * diagonal * speed * Time.deltaTime);
        //LeftLazer.transform.Translate(-diagonal * speed * Time.deltaTime);
    }
}
