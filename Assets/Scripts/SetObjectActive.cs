using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SetObjectActive : MonoBehaviour
{
    [SerializeField] PointHUD pointHUD;
    public GameObject winnerMenu;
    public GameObject loserMenu;
    public float waitTime = 10f;

    public void ActivateObject()
    {
        gameObject.SetActive(true);
        Invoke("DeActivateObject", waitTime);
    }

    public void DeActivateObject()
    {
        if (gameObject.activeInHierarchy==true && !winnerMenu.activeSelf && !loserMenu.activeSelf)
        {
            // gameObject.SetActive(false);
            pointHUD.Points -= 5;
        } else {
            gameObject.SetActive(false);
        }
    }
}
