using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;        // Object mn el CharacterController 3lshan a-call el functions bta3tha
                                                    // elly bt7rk el player
    public Rigidbody2D body;        // lel player nafso
    public Animator animator;       // lel animation


    // Some controls
    public float runSpeed = 40f;    // Controls the running speed of player
    float horizontalMove = 0f;      // movement on x-axis
    bool jump = false;              // initially we're not jumping
    bool crouch = false;            // initially we're not crouching


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; // Gets input 3n e7na bnt7rk wala la w kda, A: -1 , D: 1

        // by8yr speed el animator el 3mlnah
        // kelmet Speed mktooba hena zy el parameters henak
        // by5leeha equal horizontalMove
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (Input.GetButtonDown("Jump"))    // lw das jump, h5leeha true w kda
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }


        if (Input.GetButtonDown("Crouch"))  // tefdal true le7ad ma ybatal y-crouch
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    // Gets called every fixed amount of time
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))        // byshoof howa 3amelo hold wala la
        {
            // y2alel el gravity sa3etha
            // 3lshan yefdal tayer kda
            body.gravityScale = 1;
        }
        else
        {
            // rg3ha lel default
            // 3lshan ynzl 3l 2ard asr3
            body.gravityScale = 3;
        }

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        // Move(el sor3a, crouch, jump)
        // Time.fixedDeltaTime btedman eno yt7rk b sor3a consistent
        
        jump = false;       // hrg3ha false kda w kda, l2n mfeesh double jump fl le3ba aw kda

    }

    public void OnLand()
    {
        // lw nzl 3l 2ard, yb2a howa not jumping, 8yr el animation
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        // isCrouching dh byrg3 mn el event mazboot, fa b7aded 3la asaso el animation
        // animator.SetBool("IsCrouching", isCrouching);
    }
}
