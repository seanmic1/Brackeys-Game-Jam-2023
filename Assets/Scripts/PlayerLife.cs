using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private Animator animator;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerDie();
        }
    }

    private void PlayerDie()
    {
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
