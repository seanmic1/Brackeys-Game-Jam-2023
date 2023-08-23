using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    private Rigidbody2D bulletRb;
    private SpriteRenderer bulletRenderer;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        bulletRenderer = GetComponent<SpriteRenderer>();
        Destroy(gameObject,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletRenderer.flipX)
        {
            bulletRb.velocity = new Vector2(-speed, 0);
        }
        else 
        {
            bulletRb.velocity = new Vector2(speed, 0);  
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }
}
