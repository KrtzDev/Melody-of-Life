using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RetryScript : MonoBehaviour {

    public GameObject Gui;
    public GameObject Screen;

    public void Retry()
    {
        Gui = GameObject.Find("GUI/CanvasGUI");
        Screen.gameObject.SetActive(false);
        Gui.gameObject.SetActive(true);
        Pausescreen.PauseActive = false;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);  
    }
}
