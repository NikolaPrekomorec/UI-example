using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuH : MonoBehaviour
{

    public GameObject PauseMenuHorizontal;

    private void Awake()
    {
        //PauseMenuPortrait = GetComponent<CanvasGroup>();
    }

    public void ActivatePauseMenu()
    {
        float wh = Screen.width / Screen.height;
        if (wh >= 1)
        {
            PauseMenuHorizontal.SetActive(true);

            //PauseMenuPortrait.alpha = 1;
            //PauseMenuPortrait.interactable = true;
        }
    }
    public void DeactivatePauseMenu()
    {
        //float wh = Screen.width / Screen.height;
        //if (wh > 1)
        //{
            PauseMenuHorizontal.SetActive(false);

        //    //PauseMenuPortrait.alpha = 0;
        //    //PauseMenuPortrait.interactable = false;
        //}
    }
}
