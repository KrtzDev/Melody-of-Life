using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Level 1");
    }
    void Update()
    {
        PlayerPrefs.SetString("Level", "Tutorial Level");
    }
}
