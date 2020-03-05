using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DiagonalLazer : LazerController
{
    Vector3 diagonal = new Vector3(0.5f, 1f);

    void Update()
    {
        DestroyLazer();
        LazerMovement();
    }

    protected override void LazerMovement()
    {
        transform.Translate(diagonal * speed * Time.deltaTime);
    }
}
