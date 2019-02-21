using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickablePlatformDefiner : MonoBehaviour
{
    public Vector2 position;
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        GameObject platformToBePlaced = (GameObject)Instantiate(platform, position, transform.rotation);
        gameObject.SetActive(false);
    }
}
