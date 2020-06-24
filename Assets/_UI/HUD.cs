﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Image Image_Lives = null;
    [SerializeField] private Text Txt_Message = null;
 
    void Start()
    {
        HUDManager = this;
    }

    public void UpdateScore()
    {
        Txt_Score.text = "SCORE : " + GameManager.Score;
    }

    //updates the number of hearts for lives
    public void UpdateLives()
    {
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameManager.CurrentState = GameManager.GameState.GameOver;
        Txt_Message.color = Color.red;
        Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
