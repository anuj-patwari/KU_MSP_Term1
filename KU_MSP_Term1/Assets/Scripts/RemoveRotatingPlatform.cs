using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRotatingPlatform : MonoBehaviour
{

    public Vector2 position;
    public GameObject platform;
    public GameObject platformPlacer;


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
        if (platform.GetComponent<RotatingPlatform>().placed == true)
        {
            print("xD");
            position = new Vector2(platform.transform.position.x, platform.transform.position.y);
            GameObject platformToBePlaced = (GameObject)Instantiate(platformPlacer, position, transform.rotation);
            Destroy(platform);
        }
        
    }
}
