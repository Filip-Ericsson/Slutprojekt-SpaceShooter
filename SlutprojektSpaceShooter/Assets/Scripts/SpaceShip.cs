using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//basklassen för alla skepp i spelet. ansvarar för all rörelse, detektion av att spelaren vill skjuta och basversionen metoden Fire som kallas när ett skepp vill skjuta,
public class SpaceShip : MonoBehaviour
{

    [SerializeField]
    protected GameObject lazerBeam, player;

    protected Vector3 lazerSpawnOffset = new Vector3(0f, 0.7f, 0f); //var spelaren spawnas


    public float projectileCooldown = 0.25f; //hur ofta ett skepp kan skjuta

    private float nextFire; //nästa gång spelaren kan skjuta
           
           
    protected virtual void Fire() //när spelaren vill skjuta, instantieras en laser vid spelarens possition med en liten offset
    {
        Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire) //när spelaren klickar på mouse0, och spelaren inte har skjutit innom ett bestämt tidsintervall, 
        {

            nextFire = Time.time + projectileCooldown;
            Fire();
            
        }
        

    }
}
