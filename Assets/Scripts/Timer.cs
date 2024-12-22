using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] PointHUD pointHUD;
    public GameObject pauseMenu;
    public GameObject winnerMenu;
    public GameObject loserMenu;
    public int winningPoints;
    public int levelToUnlock;
    int numberOfUnlockedLevels;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0) {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0) {
            remainingTime = 0;
            if (pointHUD.Points >= winningPoints){
                numberOfUnlockedLevels = PlayerPrefs.GetInt("UnlockedLevel");  
                if (numberOfUnlockedLevels <= levelToUnlock){
                    PlayerPrefs.SetInt("UnlockedLevel", numberOfUnlockedLevels+1);
                }
                winnerMenu.SetActive(true);
            } else if (pointHUD.Points < winningPoints){
                loserMenu.SetActive(true);
            }
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    //void UnlockNewLevel() // Run this function if enought points earned by end of level
	//{
	//	if(SceneManager.GetActiveScene().buildIndex>=PlayerPrefs.GetInt("ReachedIndex"))
	//	{
	//		PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
	//		PlayerPrefs.SetInt("UnockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
	//		PlayerPrefs.Save();
	//	}
	//}
}
