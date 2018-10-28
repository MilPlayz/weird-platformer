using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour {

	public string mainMenuSceneName;

	public GameObject pauseMenuMain;
	public GameObject settingsMenuMenu;
	public GameObject restartMenu;
	public GameObject mainMenuMenu;

	public void backToMainPause()
	{
		settingsMenuMenu.SetActive(false);
		pauseMenuMain.SetActive(true);

	}

	public void restart()
	{
		pauseMenuMain.SetActive(false);
		restartMenu.SetActive(true);
	}

	public void cancelRestart()
	{
		pauseMenuMain.SetActive(true);
		restartMenu.SetActive(false);
	}

	public void confirmRestart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}





	public void MainMenu()
	{
		pauseMenuMain.SetActive(false);
		mainMenuMenu.SetActive(true);
	}

	public void cancelMainMenu()
	{
		pauseMenuMain.SetActive(true);
		mainMenuMenu.SetActive(false);
	}

	public void confirmMainMenu()
	{
		SceneManager.LoadScene(mainMenuSceneName);
	}


	public void settingsMenu()
	{
		settingsMenuMenu.SetActive(true);
		pauseMenuMain.SetActive(false);
	}


}
