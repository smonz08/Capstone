using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ProgressBar : MonoBehaviour
{
    [SerializeField] PointHUD pointHUD;
    public int minimum;
    public int maximum;
    public Image mask;

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float currentOffset = pointHUD.Points - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = currentOffset / maximumOffset;
        mask.fillAmount = fillAmount;
    }
}
