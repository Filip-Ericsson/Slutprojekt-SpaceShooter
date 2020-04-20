using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    float speed = 0f;
    
    void Start()
    {

        speed = Random.Range(3f, 6f);
    }

    public void DestroyAsteroid(bool hit)
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
        if (hit == true)
        {
            Destroy(gameObject);
        }
    }

    
    
    void Update()
    {
        DestroyAsteroid(false);
    }  


    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
