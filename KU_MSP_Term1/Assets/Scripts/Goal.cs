using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    GameManager gm;
    CharacterController2D cc2d;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        cc2d = FindObjectOfType<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player" && cc2d.m_Grounded == true)
        {
            SceneManager.LoadScene(gm.nextLevel);
        }
    }
}
