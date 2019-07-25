vusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
      //  Destroy(gameObject);
    }

    void Update()
    {
        rb.velocity = speed;

      //MAYCAORÉNOKIBE
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>())
            {
               Destroy(gameObject);
            }
        
    }
    void DestroyBulletCtrl()
    {
        Destroy(gameObject);
    }
}
