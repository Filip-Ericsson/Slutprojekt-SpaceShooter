using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField]
    GameObject lazerBeam, player;

    private Vector3 lazerSpawnOffset = new Vector3(0f, 0.5f, 0f);
    public float projectileCooldown = 0.25f;
    private float nextFire;
    void Start()
    {

    }

    protected virtual void Fire()
    {        
        GameObject leftLazr =  Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);
        Instantiate(lazerBeam, player.transform.position + lazerSpawnOffset, Quaternion.identity);

        leftLazr.GetComponent<DiagonalLazer>().xDir = -1;
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
