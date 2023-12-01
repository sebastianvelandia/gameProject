using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClearSky
{
    public class DemoCollegeStudentController : MonoBehaviour
    {
        public float movePower = 10f;
        // public float KickBoardMovePower = 15f;
        // public float jumpPower = 20f; //Set Gravity Scale in Rigidbody2D Component to 5

        private Rigidbody2D rb2D;
        private Animator animator;
        // public SpriteRenderer SpriteRenderer;

        // Vector3 movement;
        // private int direction = 1;
        private Vector2 direccion;
        bool isJumping = false;
        private bool alive = true;
        private bool isKickboard = false;


        // Start is called before the first frame update
        void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            Restart();
            if (alive)
            {
                // Hurt();
                // Die();
                Attack();
                // Jump();
                // KickBoard();
                Run();

            }
        }
        // private void OnTriggerEnter2D(Collider2D other)
        // {
        //     anim.SetBool("isJump", false);
        // }
        // void KickBoard()
        // {
        //     if (Input.GetKeyDown(KeyCode.Alpha4) && isKickboard)
        //     {
        //         isKickboard = false;
        //         anim.SetBool("isKickBoard", false);
        //     }
        //     else if (Input.GetKeyDown(KeyCode.Alpha4) && !isKickboard )
        //     {
        //         isKickboard = true;
        //         anim.SetBool("isKickBoard", true);
        //     }

        // }

        void Run()
        {
            if (!isKickboard)
            {
                direccion = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized;
                if (Input.GetKey("d") || Input.GetKey("right"))
                {
                    // SpriteRenderer.flipX = false;
                    animator.SetBool("isRun", true);

                } else if (Input.GetKey("a") || Input.GetKey("left"))
                {
                    // SpriteRenderer.flipX = true;
                    animator.SetBool("isRun", true);

                }else if (Input.GetKey("w") || Input.GetKey("up"))
                {
                    animator.SetBool("isRun", true);

                }else if (Input.GetKey("s") || Input.GetKey("down"))
                {
                    animator.SetBool("isRun", true);

                } else {
                    animator.SetBool("isRun", false);
                }
                // Vector3 moveVelocity = Vector3.zero;
                // anim.SetBool("isRun", false);


                // if (Input.GetAxisRaw("Horizontal") < 0)
                // {
                //     direction = -1;
                //     moveVelocity = Vector3.left;

                //     transform.localScale = new Vector3(direction, 1, 1);
                //     if (!anim.GetBool("isJump"))
                //         anim.SetBool("isRun", true);

                // }
                // if (Input.GetAxisRaw("Horizontal") > 0)
                // {
                //     direction = 1;
                //     moveVelocity = Vector3.right;

                //     transform.localScale = new Vector3(direction, 1, 1);
                //     if (!anim.GetBool("isJump"))
                //         anim.SetBool("isRun", true);

                // }
                // transform.position += moveVelocity * movePower * Time.deltaTime;

            }
            // if (isKickboard)
            // {
            //     Vector3 moveVelocity = Vector3.zero;
            //     if (Input.GetAxisRaw("Horizontal") < 0)
            //     {
            //         direction = -1;
            //         moveVelocity = Vector3.left;

            //         transform.localScale = new Vector3(direction, 1, 1);
            //     }
            //     if (Input.GetAxisRaw("Horizontal") > 0)
            //     {
            //         direction = 1;
            //         moveVelocity = Vector3.right;

            //         transform.localScale = new Vector3(direction, 1, 1);
            //     }
            //     transform.position += moveVelocity * KickBoardMovePower * Time.deltaTime;
            // }
        }

        private void FixedUpdate(){
            rb2D.MovePosition(rb2D.position + direccion * movePower * Time.fixedDeltaTime);
        }
        // void Jump()
        // {
        //     if ((Input.GetButtonDown("Jump") || Input.GetAxisRaw("Vertical") > 0)
        //     && !anim.GetBool("isJump"))
        //     {
        //         isJumping = true;
        //         anim.SetBool("isJump", true);
        //     }
        //     if (!isJumping)
        //     {
        //         return;
        //     }

        //     rb.velocity = Vector2.zero;

        //     Vector2 jumpVelocity = new Vector2(0, jumpPower);
        //     rb.AddForce(jumpVelocity, ForceMode2D.Impulse);

        //     isJumping = false;
        // }
        void Attack()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                animator.SetTrigger("attack");
            }
        }
        // void Hurt()
        // {
        //     if (Input.GetKeyDown(KeyCode.Alpha2))
        //     {
        //         anim.SetTrigger("hurt");
        //         if (direction == 1)
        //             rb.AddForce(new Vector2(-5f, 1f), ForceMode2D.Impulse);
        //         else
        //             rb.AddForce(new Vector2(5f, 1f), ForceMode2D.Impulse);
        //     }
        // }
        // void Die()
        // {
        //     if (Input.GetKeyDown(KeyCode.Alpha3))
        //     {
        //         isKickboard = false;
        //         anim.SetBool("isKickBoard", false);
        //         anim.SetTrigger("die");
        //         alive = false;
        //     }
        // }
        void Restart()
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                isKickboard = false;
                animator.SetBool("isKickBoard", false);
                animator.SetTrigger("idle");
                alive = true;
            }
        }
    }

}