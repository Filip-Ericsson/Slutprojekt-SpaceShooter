using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script som kontrolerar asteroiderna i spelet
public class AsteroidController : MonoBehaviour
{
    float speed = 0f; //deklareras variabel som sedan multipliceras med en Vector3. Bestämmer hastigheten på asteroiderna
    
    void Start()
    {

        speed = Random.Range(3f, 6f); //för ovanstående variabel slumpas värdet för varje asteroid
    }

    public void DestroyAsteroid(bool hit) //metod som körs när antigen asteroiders y-värde är för lågt eller när det kolliderar med något
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject); //förstör gameObjected som scriptet sitter på
        }
        if (hit == true)
        {
            Destroy(gameObject);
        }
    }

    
    
    void Update()
    {
        DestroyAsteroid(false); //körs för att se om asteroiden är under det bestämda y-värdet, har värde false eftersom den inte har kolliderat med något när metoden körs från Update
    }  


    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);  //förflyttar stenen i negativ y-led
    }
}
