using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayGame ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

	public void PauseGame() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
	}


}
