using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange2 : MonoBehaviour {

    

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Level 2");
    }
    void Update()
    {
        PlayerPrefs.SetString("Level", "Level 1");
    }
}
