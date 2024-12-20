using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
	private void onTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			// SceneController.instance.NextLevel();
		}
	}
}
