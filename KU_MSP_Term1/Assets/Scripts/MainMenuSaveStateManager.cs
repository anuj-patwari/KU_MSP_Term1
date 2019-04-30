using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainMenuSaveStateManager : MonoBehaviour
{
    [SerializeField] GameObject mainGroup;
    [SerializeField] GameObject saveStateGroup;

    GlobalAudioManager gam;

    // Start is called before the first frame update
    void Start()
    {
        gam = FindObjectOfType<GlobalAudioManager>();
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            if (gam.levelsCompleted > 0)
            {
                saveStateGroup.SetActive(true);
                mainGroup.SetActive(false);
            }
        }
        else
        {
            saveStateGroup.SetActive(false);
            mainGroup.SetActive(true);
        }

        if (gam.levelsCompleted == 0)
        {
            saveStateGroup.SetActive(false);
            mainGroup.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewGame()
    {
        gam.NewGame();
    }

    public void LoadGame()
    {
        gam.LoadGame();
    }

}
