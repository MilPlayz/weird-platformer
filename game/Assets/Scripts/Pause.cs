using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject pauseMenu;
	public bool isInPauseMenu = false;
	bool pauseAxisIsInUse = false;

	void Update()
	{
		float p = Input.GetAxisRaw("Pause");

		if(p != 0)
		{

			if(pauseAxisIsInUse == false)
			{
				if (isInPauseMenu)
				{
					pauseMenu.SetActive(false);
					Time.timeScale = 1;
					isInPauseMenu = false;
				}
				else
				{
					pauseMenu.SetActive(true);
					Time.timeScale = 0;
					isInPauseMenu = true;
				}
				pauseAxisIsInUse = true;
			}





		}
		else
		{
			pauseAxisIsInUse = false;
		}

	}
}
