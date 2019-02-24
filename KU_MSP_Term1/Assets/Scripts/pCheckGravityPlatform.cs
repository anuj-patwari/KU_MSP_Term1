using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pCheckGravityPlatform : MonoBehaviour
{

    public bool placed = false;
    public GameObject crossButton;

    // Start is called before the first frame update
    void Start()
    {
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
        
    }
}
