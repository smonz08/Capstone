using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SetObjectActive : MonoBehaviour
{
    [SerializeField] PointHUD pointHUD;

    public void ActivateObject()
    {
        gameObject.SetActive(true);
        Invoke("DeActivateObject", 10f);
    }

    public void DeActivateObject()
    {
        if (gameObject.activeInHierarchy==true)
        {
            // gameObject.SetActive(false);
            pointHUD.Points -= 5;
        } else {
            gameObject.SetActive(false);
        }
    }
}
