using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Vector2 startingCoordinates;
    [SerializeField]
    GameObject player;

    public string nextLevel;

    public float platformIDNumber;

    //Gravity Platform Variables
    public float negativeGravity;
    public float positiveGravity;
    public float currentLevelStartingGravity = 3f;

    // Start is called before the first frame update
    void Start()
    {
        startingCoordinates = player.transform.position;
        platformIDNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
