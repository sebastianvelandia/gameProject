using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float runSpeed;
    // public float jumpSpeed = 3;

    private Vector2 direccion;

    public SpriteRenderer SpriteRenderer;
    public Animator animator;
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized;
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            SpriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        } else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            SpriteRenderer.flipX = true;
            animator.SetBool("Run", true);

        }else if (Input.GetKey("w") || Input.GetKey("up"))
        {
            animator.SetBool("Run", true);

        }else if (Input.GetKey("s") || Input.GetKey("down"))
        {
            animator.SetBool("Run", true);

        } else {
            animator.SetBool("Run", false);
        }
        
        
    }

    private void FixedUpdate(){
        rb2D.MovePosition(rb2D.position + direccion * runSpeed * Time.fixedDeltaTime);
    }
}
