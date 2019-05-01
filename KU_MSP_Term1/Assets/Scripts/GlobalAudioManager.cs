﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GlobalAudioManager : MonoBehaviour
{

    public static GlobalAudioManager gam;

    public int levelsCompleted;

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
    }

    private void Start()
    {
        ReloadSavedGame();
        Application.targetFrameRate = 150;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
            {
                File.Delete(Application.persistentDataPath + "/playerInfo.dat");
            }
        }
    }
    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();

        data.levelsCompleted = levelsCompleted;

        bf.Serialize(file, data);
        file.Close();
    }

    public void ReloadSavedGame()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            levelsCompleted = data.levelsCompleted;
        }
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            levelsCompleted = data.levelsCompleted;

            if (levelsCompleted == 1)
            {
                SceneManager.LoadScene("Level2");
            }
            else if (levelsCompleted == 2)
            {
                SceneManager.LoadScene("Level3");
            }
            else if (levelsCompleted == 3)
            {
                SceneManager.LoadScene("Level4");
            }
            else if (levelsCompleted == 4)
            {
                SceneManager.LoadScene("Level5");
            }
            else if (levelsCompleted == 5)
            {
                SceneManager.LoadScene("Level6");
            }
            else if (levelsCompleted == 6)
            {
                SceneManager.LoadScene("Level7");
            }
            else if (levelsCompleted == 7)
            {
                SceneManager.LoadScene("Level8");
            }
            else if (levelsCompleted == 8)
            {
                SceneManager.LoadScene("Level9");
            }
            else if (levelsCompleted == 9)
            {
                SceneManager.LoadScene("Level10");
            }

        }
    }

    public void NewGame()
    {
        levelsCompleted = 0;
        SaveGame();
        SceneManager.LoadScene("Level1");
    }
}

[Serializable]
class PlayerData
{
    public int levelsCompleted;
}