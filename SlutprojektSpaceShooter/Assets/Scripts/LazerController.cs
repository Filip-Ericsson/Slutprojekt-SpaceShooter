using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField]
    protected float speed = 1f;
    

    void Update()
    {
        DestroyLazer();
        LazerMovement();
    }
    protected void DestroyLazer()
    {
        if (transform.position.y > 8f)
        {
            Destroy(gameObject);
        }
    }
    protected virtual void LazerMovement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
