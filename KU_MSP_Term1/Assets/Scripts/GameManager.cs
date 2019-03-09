using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public Vector2 startingCoordinates;
    [SerializeField]
    GameObject player;

    public string nextLevel;

    public float platformIDNumber;

    //Preparation phase Variables
    public static UnityEvent PrepPhaseEnded = new UnityEvent();
    public static UnityEvent PrepPhaseStarted = new UnityEvent();
    public bool prepPhase;
    public GameObject inventory;
    public GameObject startButton;
    public GameObject prepPhaseButton;
    
    //Gravity Platform Variables
    public float negativeGravity;
    public float positiveGravity;
    public float currentLevelStartingGravity = 3f;

    // Start is called before the first frame update
    void Start()
    {
        startingCoordinates = player.transform.position;
        platformIDNumber = 0;
        prepPhase = true;
        prepPhaseButton.SetActive(false);
        startButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndPrepPhase()
    {
        prepPhase = false;
        inventory.SetActive(false);
        startButton.SetActive(false);
        prepPhaseButton.SetActive(true);
        PrepPhaseEnded.Invoke();
    }

    public void StartPrepPhase()
    {
        prepPhase = true;
        inventory.SetActive(true);
        startButton.SetActive(true);
        prepPhaseButton.SetActive(false);
        PrepPhaseStarted.Invoke();


        //Sending player back to the start of the level
        player.transform.position = startingCoordinates;
        player.GetComponent<Rigidbody2D>().gravityScale = currentLevelStartingGravity;
        if (currentLevelStartingGravity > 0)
        {
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (currentLevelStartingGravity < 0)
        {
            player.transform.eulerAngles = new Vector3(0, 0, 180f);
        }
    }
}
