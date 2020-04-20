using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    [SerializeField]
    protected GameObject lazerBeam, player;

    protected Vector3 lazerSpawnOffset = new Vector3(0f, 0.7f, 0f);


    public float projectileCooldown = 0.25f;

    private float nextFire;

    /*protected float speedX = 5f;
    protected float speedY = 0.1f;
    
    PlayerController controller = new PlayerController();*/
    

    
   
    protected virtual void Fire()
    {
        Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {

            nextFire = Time.time + projectileCooldown;
            Fire();
            
        }
        

    }
}
