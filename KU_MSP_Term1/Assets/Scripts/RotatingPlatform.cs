using System.Collections;
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
            if (transform.rotation.z == 0 || transform.rotation.z == -360 )
            {
                anim.enabled = true;
                anim.Play("RotatingPlatform2");
            }
            
            if (transform.rotation.eulerAngles.z > -185 && transform.rotation.eulerAngles.z < -175)
            {
                print("hola");
                anim.enabled = true;
                anim.Play("RotatingPlatform2");
            }
        }
    }
}
