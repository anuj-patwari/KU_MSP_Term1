﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{

    CharacterController2D controller;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<CharacterController2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (transform.rotation.z == 0 || transform.rotation.z == 360 )
            {
                anim.enabled = true;
                anim.Play("RotateTo180");
                StartCoroutine (DisableAnimator(1));
            }
            
            if (transform.rotation.z == -180)
            {
                print("hola");
                anim.enabled = true;
                anim.Play("RotatingPlatform2");
                StartCoroutine(DisableAnimator(1));
            }
        }
    }

    IEnumerator DisableAnimator(float delay)
    {
        yield return new WaitForSeconds(delay);
        //anim.enabled = false;
    }
}
