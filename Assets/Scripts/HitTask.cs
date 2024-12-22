using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HitTask : MonoBehaviour
{
	[SerializeField] PointHUD pointHUD;
	public int taskPoints;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			pointHUD.Points += taskPoints;
			gameObject.SetActive(false);
		}
	}
}
