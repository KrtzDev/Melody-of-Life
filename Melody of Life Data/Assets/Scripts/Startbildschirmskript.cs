using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbildschirmskript : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {

        PlayerPrefs.DeleteAll();
		SceneManager.LoadScene(1);
		
	}
	
	// Update is called once per frame
	public void EndGame () {
		
		Application.Quit ();
	}
}
