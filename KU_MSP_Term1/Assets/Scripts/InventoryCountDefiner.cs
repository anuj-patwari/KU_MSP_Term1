﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCountDefiner : MonoBehaviour
{
    public GameObject rotatingText;
    public GameObject gravityText;
    public GameObject jumpPlatText;
    public GameObject getKeyText;
    public GameObject deathCounter;

    GlobalAudioManager gam;

    // Start is called before the first frame update
    void Start()
    {
        gam = FindObjectOfType<GlobalAudioManager>();
        Player.PlayerDied.AddListener(OnPlayerDied);
        deathCounter.GetComponent<Text>().text = "Deaths = " + gam.deaths.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlayerDied()
    {
        deathCounter.GetComponent<Text>().text = "Deaths = " + gam.deaths.ToString();
    }
}
