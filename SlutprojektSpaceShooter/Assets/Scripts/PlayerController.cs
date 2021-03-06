﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//samma script som när vi gjorde detta i unity shooter förra året
public class PlayerController : MonoBehaviour
{
    private float speedX = 5f;
    private float speedY = 0.1f;
    
    

    public void PlayerMovement(float speedX, float speedY)
    {

        Debug.Log(speedX);

        float xAxis = Input.GetAxisRaw("Horizontal");
        //Debug.Log(xAxis);
        Debug.Log(speedX);
        transform.Translate(Vector3.right * speedX * xAxis * Time.deltaTime);
        speedX += 0.2f;
        speedX = Mathf.Clamp(speedX, 5f, 8f);
        Debug.Log(speedX);
        //print(transform.position.x);


        float yAxis = Input.GetAxisRaw("Vertical");

        //Debug.Log(yAxis);


        transform.Translate(Vector3.up * speedY * yAxis);
        speedY += 0.015f;
        speedY = Mathf.Clamp(speedY, 0.1f, 0.15f);
    }

    void PlayerWarp()
    {
        if (transform.position.x < -3.2f)  //warpar från vänsterkanten till högerkanten
        {
            Vector3 Xwarp1 = new Vector3(3.2f, transform.position.y);
            transform.position = Xwarp1;
        }
        else if (transform.position.x > 3.2f) // warpar från högerkanten till vänsterkanten
        {
            Vector3 Xwarp2 = new Vector3(-3.2f, transform.position.y);
            transform.position = Xwarp2;
        }

        if (transform.position.y < -4.7f) //Tvingar spelarn att stanna innom yaxeln
        {
            Vector3 Ywarp1 = new Vector3(transform.position.x, -4.7f);
            transform.position = Ywarp1;
        }
        else if (transform.position.y > 4.7f)
        {
            Vector3 Ywarp2 = new Vector3(transform.position.x, 4.7f);
            transform.position = Ywarp2;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        PlayerMovement(speedX, speedY);

        PlayerWarp();

    }

   void OnCollisionEnter2D(Collision2D collision)
    {        
        if(collision.gameObject.tag == "asteroid")
        {
            Debug.Log("ASTEROID!");
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
