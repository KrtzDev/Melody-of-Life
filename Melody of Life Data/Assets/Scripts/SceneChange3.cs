using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange3 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(5);
    }
    void Update()
    {
        PlayerPrefs.SetString("Level", "Level 2");
    }
}
