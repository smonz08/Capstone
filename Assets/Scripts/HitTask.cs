using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HitTask : MonoBehaviour
{
	[SerializeField] PointHUD pointHUD;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			pointHUD.Points += 10;
			gameObject.SetActive(false);
		}
	}
}
