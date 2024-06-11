using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float destroyPosY = 10f;
    public GameObject explosionPrefab;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, speed);
        if (transform.position.y >= destroyPosY)
        {
            Destroy(gameObject);
        }
    }   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigos")
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(collision.gameObject); 
            Destroy(gameObject);
        }
    }
}
