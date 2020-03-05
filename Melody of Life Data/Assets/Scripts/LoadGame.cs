using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    public string LeveltoLoad;

    public void Load()
    {
        Gamemanager.Health = PlayerPrefs.GetInt("Leben");
        LeveltoLoad = PlayerPrefs.GetString("Level");     
        SceneManager.LoadScene(LeveltoLoad);
    }
}
