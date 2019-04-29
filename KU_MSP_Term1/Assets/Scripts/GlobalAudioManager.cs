using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAudioManager : MonoBehaviour
{

    public static GlobalAudioManager gam;

    // Start is called before the first frame update
    void Awake()
    {
        if (gam == null)
        {
            DontDestroyOnLoad(gameObject);
            gam = this;
        }
        else if (gam != null)
        {
            Destroy(gameObject);
        }
        //gameObject.GetComponent<AudioSource>().Play(0);
    }

    private void Start()
    {
        Application.targetFrameRate = 150;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
