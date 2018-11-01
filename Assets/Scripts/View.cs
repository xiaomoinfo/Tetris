﻿using DG.Tweening;
using UnityEngine;

/**
*  作   者 ：胡朋
*  github : https://github.com/xiaomoinfo
*  描   述 ：视图
*/
public class View : MonoBehaviour
{
    private RectTransform logoName;

    private RectTransform menUI;
    private RectTransform gameUI;
    private RectTransform gameOverUI;
    private RectTransform settingUI;
    private RectTransform pauseUI;


    private void Start()
    {
        logoName = transform.Find("Canvas/Logo") as RectTransform;

        menUI = transform.Find("Canvas/MenuUI") as RectTransform;
        gameUI = transform.Find("Canvas/GameUI") as RectTransform;
        gameOverUI = transform.Find("Canvas/GameOverUI") as RectTransform;
        settingUI = transform.Find("Canvas/SettingUI") as RectTransform;
        pauseUI = transform.Find("Canvas/PauseUI") as RectTransform;
    }


    public void ShowMenu()
    {
        logoName.gameObject.SetActive(true);
        logoName.DOAnchorPosY(480f, 0.5f);

        menUI.gameObject.SetActive(true);
        menUI.DOAnchorPosY(60.5f, 0.5f);
    }

    public void HideMenu()
    {
        logoName.DOAnchorPosY(640f, 0.5f)
            .OnComplete(delegate { logoName.gameObject.SetActive(false); });
        
        menUI.DOAnchorPosY(-95f, 0.5f)
            .OnComplete(delegate { menUI.gameObject.SetActive(false); });
    }

    public void ShowGame()
    {
        gameUI.gameObject.SetActive(true);
        gameUI.DOAnchorPosY(-70f, 0.5f);
    }

    public void HideGame()
    {
        gameUI.DOAnchorPosY(-70f, 0.5f)
            .OnComplete(delegate { gameUI.gameObject.SetActive(false); });
    }
}