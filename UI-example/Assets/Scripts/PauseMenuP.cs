using UnityEngine;
using System.Collections;

public class PauseMenuP : MonoBehaviour
{
    public GameObject PauseMenuPortrait;

    private void Awake()
    { 
        //PauseMenuPortrait = GetComponent<CanvasGroup>();
    }

    public void ActivatePauseMenu()
    {
        float wh = Screen.width / Screen.height;
        if (wh <= 1)
        {
            PauseMenuPortrait.SetActive(true);

            //PauseMenuPortrait.alpha = 1;
            //PauseMenuPortrait.interactable = true;
        }
    }
    public void DeactivatePauseMenu()
    {
        //float wh = Screen.width / Screen.height;
        //if (wh <= 1)
        //{
            PauseMenuPortrait.SetActive(false);

        //    //PauseMenuPortrait.alpha = 0;
        //    //PauseMenuPortrait.interactable = false;
        //}
    }
}
