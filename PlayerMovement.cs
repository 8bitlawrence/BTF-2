using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;
    bool moving = false;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        

    }

     private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        animator.SetBool("Moving", moving);
        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);

        if (moveX!=0)
        {
            movement.x = moveX;
            movement.y = 0;
            moving = true;
            Debug.Log("Player moving");
        }

        else if (moveY != 0)    
        {
            movement.x = 0;
            movement.y = moveY;
            moving = true;
            Debug.Log("Player moving");
        }

        else if (moveX == 0 && moveY == 0)
        {
            moving = false;
            movement = Vector2.zero;
            Debug.Log("Player stopped moving");
        } 


    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movement * speed;
    }
}
