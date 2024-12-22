using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointHUD : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI pointText;
	public int maximum;
	int points = 0;

	private void Awake () {
		UpdateHUD();
	}

	public int Points {
		get {
			return points;
		}

		set {
			if (points < maximum){
				points = value;
				UpdateHUD();
			} else if (points > maximum){
				points = maximum;
			}
		}
	}

	private void UpdateHUD () {
		pointText.text = points.ToString ();
	}

}
