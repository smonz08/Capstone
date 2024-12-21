using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
	[SerializeField] PointHUD pointHUD;
	public int maximum;

	private void Start () {
		StartCoroutine (CountPoints ());
	}

	private IEnumerator CountPoints () {
		while(true){
			// pointHUD.Points += 5;

			yield return new WaitForSeconds(1);
		}
	}
}
