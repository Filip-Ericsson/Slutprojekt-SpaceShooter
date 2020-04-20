using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{    
    float speed = 0f;
    
    void Start()
    {
       
        float posX = Random.Range(-2.8f, 2.8f);
        float posY = Random.Range(-9f, 9f);
        
        
        Vector3 startPos = new Vector3(posX, posY);


        transform.position = startPos;

    }


    void FixedUpdate()
    {
        float speed = Random.Range(9f, 6f);
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        
    }
    void Update()
    {

        if (transform.position.y < -5f)
        {
            float posX = Random.Range(-2.8f, 2.8f);
            Vector3 startPos = new Vector3(posX, 5f);
            transform.position = startPos;
        }


    }
}
