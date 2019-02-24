using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGravityPlatform : MonoBehaviour
{
    public Vector2 position;
    public GameObject platform;
    public GameObject platformPlacer;
    public GameObject gravScriptObject;

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
        if (platform.GetComponent<pCheckGravityPlatform>().placed == true)
        {
            print("gravityPlatform");
            position = new Vector2(platform.transform.position.x, platform.transform.position.y);
            GameObject platformToBePlaced = (GameObject)Instantiate(platformPlacer, position, transform.rotation);
            Destroy(platform);
        }

    }
}
