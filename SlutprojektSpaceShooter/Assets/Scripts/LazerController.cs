using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField]
    protected float speed = 1f;

    public Vector3 lazerDir = new Vector3(0f, 1f);
    //GameObject asteroid = new GameObject();
    void FixedUpdate()
    {
        LazerMovement();
    }
    protected virtual void DestroyLazer()
    {
        Destroy(gameObject);
    }
    protected virtual void AsteroidCollision(Collision2D collision)
    {
        AsteroidController asteroid = collision.gameObject.GetComponent<AsteroidController>();
        asteroid.DestroyAsteroid(true);
        DestroyLazer();
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "asteroid")
        {
            AsteroidCollision(collision);
        }
    }
    protected virtual void LazerMovement()
    {
        transform.Translate(lazerDir * speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {
            DestroyLazer();
        }
    }
}
