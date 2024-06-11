using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Rigidbody2D rbd;
    public float speed = 2f;
    public float tiempoParaCrearEnemigo = 3f;
    public float tiempoActualDeCrearEnemigo = 0f;
    public float randomX;
    public float maxX = 7f;
    public float minX = -7f;
    public float spawnY = 8f;

    private void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        CreateEnemy();
    }
    void CreateEnemy()
    {
        randomX = Random.Range(minX,maxX);

        Vector2 randomPosition = new Vector2(randomX, spawnY);

        Instantiate(enemyPrefab,randomPosition,transform.rotation);
    }
    void Update()
    {
        tiempoActualDeCrearEnemigo = tiempoActualDeCrearEnemigo + Time.deltaTime;

        if(tiempoActualDeCrearEnemigo >= tiempoParaCrearEnemigo)
        {
            CreateEnemy();
            tiempoActualDeCrearEnemigo = 0;
        }
    }
    private void FixedUpdate()
    {
        rbd.velocity = new Vector2(0, speed);
    }
}
