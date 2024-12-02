using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scrumf : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed = 20f;
    [SerializeField] float jumpForce = 15f;
    Rigidbody2D rb;
    Vector3 movement = Vector3.zero;
    private bool isGrounded = true;
    private float verticalVelocity = 0f;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    public void Move(Vector3 movement)
    {
       
         rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
         if (movement.y > 0 && isGrounded)
        {
            verticalVelocity = jumpForce;
            rb.AddForce(Vector2.up * verticalVelocity, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("Ground"))
       {
            isGrounded = true;
       }
       else if(collision.gameObject.CompareTag("Platform"))
       {
            isGrounded = true;
       }
       else if(collision.gameObject.CompareTag("Spike"))
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }
       else if(collision.gameObject.CompareTag("Coin"))
       {
            
            Destroy(collision.gameObject);
       }
       else if(collision.gameObject.CompareTag("Collectable"))
       {
           SceneManager.LoadScene("Main Menu");
       }
       else if (collision.gameObject.CompareTag("Hazard"))
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }
       
    }

}
   
