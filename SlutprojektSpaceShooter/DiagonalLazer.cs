using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class DiagonalLazer : LazerController
{
    Vector3 diagonal = new Vector3(1f,-0.5f);
    
    void Update()
    {
        LazerMovement();
    }

    protected override void LazerMovement()
    {
        transform.Translate(diagonal * speed * Time.deltaTime);
    }
}

