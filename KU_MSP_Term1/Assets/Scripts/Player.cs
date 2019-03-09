using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    public CharacterController2D controller;
    public static UnityEvent PlayerDied = new UnityEvent();

    public Animator animator;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {

            jump = true;

            if (controller.m_JumpForce != 0)
            {
                animator.SetBool("IsJumping", true);
            }
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Die()
    {
        PlayerDied.Invoke();
    }
}