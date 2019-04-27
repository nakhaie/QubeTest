﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Text coinText, gemText;
    public Button[] modeGameBtns;
    public Button[] pnlBtns;
    public GameObject[] pnlGo;
    void Start()
    {
        setCoinGem();
        for (int i = 0; i < modeGameBtns.Length; i++)
            clickModesBtn(modeGameBtns[i], i);

        for (int i = 0; i < pnlBtns.Length; i++)
            clickPnlBtns(pnlBtns[i], i);

    }
    void clickModesBtn(Button btn, int indexMode)
    {
        btn.onClick.AddListener(() => { onClickmodesGames(indexMode); });
    }
    void clickPnlBtns(Button btn, int indexMode)
    {
        btn.onClick.AddListener(() => { onClickPnlBtns(indexMode); });
    }
    void onClickmodesGames(int indexMode)
    {
        if(indexMode==0)//raceEve
        {

        }
        else if (indexMode == 1)//arcade
        {

        }
        else if (indexMode == 3)//timeChallenge
        {

        }
    }
    void onClickPnlBtns(int indexMode)
    {
        pnlGo[indexMode].SetActive(true);

        if (indexMode == 0)//shop
        {

        }
        else if (indexMode == 1)//setting
        {

        }
        else if (indexMode == 3)//leaderboard
        {

        }
    }
   
    public void setCoinGem()
    {
        coinText.text = "10";
        gemText.text = "10";
    }
    void Update()
    {
        
    }
}
