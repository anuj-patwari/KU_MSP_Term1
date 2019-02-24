using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{

    CharacterController2D controller;
    JumpDisable jd;
    public Animator anim;
    public bool placed = false;
    public GameObject crossButton;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<CharacterController2D>();
        jd = FindObjectOfType<JumpDisable>();
        anim = GetComponent<Animator>();
        Player.PlayerDied.AddListener(OnPlayerDied);
        if (placed == true)
        {
            crossButton.SetActive(true);
        }
        else if (placed == false)
        {
            crossButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && controller.m_Grounded && jd.jumpEnabled)
        {
            if (transform.rotation.eulerAngles.z == 0 || transform.rotation.eulerAngles.z == -360)
            {
                anim.enabled = true;
                anim.Play("RotateTo180");
            }

            if (transform.rotation.eulerAngles.z == Mathf.Abs(180f))
            {
                anim.enabled = true;
                anim.Play("RotatingPlatform2");
            }
        }
    }

    void OnPlayerDied()
    {
        if (transform.rotation.eulerAngles.z == Mathf.Abs(180f))
        {
            anim.enabled = true;
            anim.Play("RotatingPlatform2");
        }
    }
}