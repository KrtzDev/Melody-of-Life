using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainMenu : MonoBehaviour {

    public GameObject Screen;
    public GameObject Gui;
    public void MainMenu()
    {
        Gui = GameObject.Find("GUI/CanvasGUI");
        Gui.gameObject.SetActive(true);
        SceneManager.LoadScene("StartMenu");
        Destroy(Screen.gameObject);
    }
}
