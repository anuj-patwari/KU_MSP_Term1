using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedPlatform : MonoBehaviour
{
    [SerializeField]
    GameObject delayedPlatform;
    [SerializeField]
    GameObject baseDelayedPlatform;

    // Start is called before the first frame update
    void Start()
    {
        Player.PlayerDied.AddListener(OnPlayerDied);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            StartCoroutine(DestroyInFiveSeconds(1.6f));
        }
    }

    IEnumerator DestroyInFiveSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        baseDelayedPlatform.SetActive(false);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    void OnPlayerDied()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        baseDelayedPlatform.SetActive(true);
    }
}
