using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Baddie : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D box;
    [SerializeField] private float speed;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Bullet"))
        {
            GameManager.instance.AddEnemyKillCount();
            Destroy(gameObject);
        }
    }
    
}
