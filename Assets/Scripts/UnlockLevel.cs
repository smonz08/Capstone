using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockLevel : MonoBehaviour
{
	void UnlockNewLevel() // Run this function if enought points earned by end of level
	{
		if(SceneManager.GetActiveScene().buildIndex>=PlayerPrefs.GetInt("ReachedIndex"))
		{
			PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
			PlayerPrefs.SetInt("UnockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
			PlayerPrefs.Save();
		}
	}
}
