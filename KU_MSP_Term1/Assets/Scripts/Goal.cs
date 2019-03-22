using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    GameManager gm;
    CharacterController2D cc2d;
    InventoryCountDefiner invCount;
    public GameObject getKeyText;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        cc2d = FindObjectOfType<CharacterController2D>();
        invCount = FindObjectOfType<InventoryCountDefiner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if(gm.hasKey == true)
            {
                SceneManager.LoadScene(gm.nextLevel);
            }

            else if (gm.hasKey == false)
            {
                getKeyText.SetActive(true);
                StartCoroutine(DeactivateText(3));
            }
        }
    }

    IEnumerator DeactivateText(float delay)
    {
        yield return new WaitForSeconds(delay);
        getKeyText.SetActive(false);
    }
}
