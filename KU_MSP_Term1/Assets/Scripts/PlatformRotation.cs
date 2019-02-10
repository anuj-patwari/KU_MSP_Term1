using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.Play("RotateTo180");
        //StartCoroutine (PlaySecondAnim(2));
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("space"))
        {
            if (transform.rotation.z == 0 || transform.rotation.z == 360)
            {
                anim.Play("RotateTo180");
            }
        }*/
        if (Input.GetKeyDown("space"))
        { 
            if (transform.rotation.z == -180)
            {
                anim.Play("RotatingPlatform2");
                print("ss");
            }
        }
    }

    IEnumerator PlaySecondAnim(float delay)
    {
        yield return new WaitForSeconds(delay);
        anim.Play("RotatingPlatform2");
    }
}
