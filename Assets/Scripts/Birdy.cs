using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
           if(collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
        }
    }
}
