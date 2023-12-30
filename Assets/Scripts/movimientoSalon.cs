using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoSalon : MonoBehaviour
{
    public float runSpeed = 5;
    public SpriteRenderer SpriteRenderer;
    public Animator animator;
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            SpriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        } 
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            SpriteRenderer.flipX = true;
            animator.SetBool("Run", true);

        }else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }
    }

}