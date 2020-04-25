using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script som ärver från LazerController
class DiagonalLazer : LazerController
{
    
    Vector3 diagonal = new Vector3(0.5f, 1f); //får en ny vector3 för diagonal rörelse

    public float xDir = 0.6f; //denna variabel bestämmer hur stor eller liten vinkel lasern kommer att färdas med från skeppet. hur mycker diagonalt den åker
    public float yDir = 1f;

   

    protected override void LazerMovement() //överskrider basklassens metod för rörelse 
    {
        diagonal = new Vector3(xDir, yDir);
        transform.Translate(diagonal * speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {
            DestroyLazer();
        }

    }
}
