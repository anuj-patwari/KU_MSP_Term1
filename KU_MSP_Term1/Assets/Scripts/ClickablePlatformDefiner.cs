using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickablePlatformDefiner : MonoBehaviour
{
    public Vector2 position;
    public GameObject rotatingPlatform;
    public GameObject gravityPlatform;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        GameManager.PrepPhaseEnded.AddListener(PreparationHasEnded);
        GameManager.PrepPhaseStarted.AddListener(PreparationHasStarted);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gm.platformIDNumber == 1)
        {
            position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            GameObject platformToBePlaced = (GameObject)Instantiate(rotatingPlatform, position, transform.rotation);
            Destroy(gameObject);
            gm.platformIDNumber = 0;
            rotatingPlatform.GetComponent<RotatingPlatform>().placed = true;
        }

        if (gm.platformIDNumber == 2)
        {
            position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            GameObject platformToBePlaced = (GameObject)Instantiate(gravityPlatform, position, transform.rotation);
            gameObject.SetActive(false);
            gm.platformIDNumber = 0;
            gravityPlatform.GetComponent<pCheckGravityPlatform>().placed = true;
        }

    }

    void PreparationHasEnded()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    void PreparationHasStarted()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
