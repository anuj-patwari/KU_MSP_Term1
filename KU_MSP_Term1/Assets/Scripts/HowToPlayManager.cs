using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayManager : MonoBehaviour
{
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;
    [SerializeField] GameObject howToPlayText;
    [SerializeField] GameObject controlsText;

    private int menuNumber;

    // Start is called before the first frame update
    void Start()
    {
        menuNumber = 1;
        leftButton.SetActive(false);
        howToPlayText.SetActive(true);
        controlsText.SetActive(false);
        rightButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchButtonClicked()
    {
        if (menuNumber == 1)
        {
            rightButton.SetActive(false);
            howToPlayText.SetActive(false);
            controlsText.SetActive(true);
            leftButton.SetActive(true);
            menuNumber = 2;
        }

        else if (menuNumber == 2)
        {
            leftButton.SetActive(false);
            howToPlayText.SetActive(true);
            controlsText.SetActive(false);
            rightButton.SetActive(true);
            menuNumber = 1;
        }
    }
}
