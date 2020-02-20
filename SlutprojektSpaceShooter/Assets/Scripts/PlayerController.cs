using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    GameObject lazerBeam;
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(lazerBeam);
        }
        
    }
}
