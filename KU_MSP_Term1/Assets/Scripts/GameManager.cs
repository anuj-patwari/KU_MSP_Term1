using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Vector2 startingCoordinates;
    [SerializeField]
    GameObject player;

    //Gravity Platform Variables
    public float negativeGravity;
    public float positiveGravity;

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = startingCoordinates;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
