using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedX = 8f;
    public float speedy = 8f;
    public float horizontal;
    public float vertical;
    public GeneradordeBalas generadorBalas;
    private Rigidbody2D rbd;

    void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if(Input.GetMouseButtonDown(0))
        {
            generadorBalas.Disparar();
        }
    }
    private void FixedUpdate()
    {
        rbd.velocity = new Vector2(speedX * horizontal, speedy * vertical);
    }
}
