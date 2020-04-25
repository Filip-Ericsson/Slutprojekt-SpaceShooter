using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{//Detta är basklassen för alla lasrar i spelet. 
    //koden kontrolerar hur baslasern förflyttas, att asteroider förstörs när de kolliderar och att även lasern förstörs vid kollision
    [SerializeField]
    protected float speed = 1f;

    public Vector3 lazerDir = new Vector3(0f, 1f);
    
    void FixedUpdate()
    {
        LazerMovement(); //att lasern förflyttar
    }
    protected virtual void DestroyLazer() //metod som förstör gameObjektet som scriptet sitter på.
    {
        Destroy(gameObject);
    }
    protected virtual void AsteroidCollision(Collision2D collision) //vid en kollision som sker med ett objekt med taggen "asteroid" förstörs asteroiden som kolliderades med och lasern som kolliderade
    {
        AsteroidController asteroid = collision.gameObject.GetComponent<AsteroidController>();
        asteroid.DestroyAsteroid(true);
        DestroyLazer();
    }
    protected void OnCollisionEnter2D(Collision2D collision) //kollar efter kollisioner
    {

        if (collision.gameObject.tag == "asteroid") //om lasern kolliderar med en "asteroid"
        {
            AsteroidCollision(collision);
        }
    }
    protected virtual void LazerMovement() //baslaserns förflyttelse
    {
        transform.Translate(lazerDir * speed * Time.deltaTime);

        if (transform.position.y > 8f) //om lasern befinner sig ovan den bestämda max gränsen, förstörs objektet
        {
            DestroyLazer();
        }
    }
}
