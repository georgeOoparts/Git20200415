﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//k7 textmeshpro を使う場合
using TMPro;

public class H_99_60_StartPanelControll : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public H_99_01B_kyotuElapse kyotuEla;
    //UIパネルのAutoSavePanelオブジェを直接　消したり、出したりするのに使う
    public GameObject AutoSavePanel;
    //TextMeshProUGUIのtextオブジェを消したり、出したりするのに使う
    public GameObject ReallyText;

    public GameObject StartButtonText;
    int YesCount = 0;
    //public GameObject StartButton;
    void Start()
    {
        //k7 textmeshpro を使う場合　直接enableを記述しなければならない
        //Title.GetComponent<TextMeshProUGUI>().enabled = kyotuEla.tenmetuOnOff;//ok
        
    }

    // Update is called once per frame
    void Update()
    {
        if (YesCount == 0)
        {
            //k7 textmeshpro を使う場合　直接enableを記述しなければならない
            ReallyText.GetComponent<TextMeshProUGUI>().enabled = false;
        }
        else if (YesCount == 1) 
        {
            //k7 textmeshpro を使う場合　直接enableを記述しなければならない
            ReallyText.GetComponent<TextMeshProUGUI>().enabled = true;
        }
        else if(YesCount == 2) 
        {
            //savedata resetするときの処理　一番最初の初期値を入れる。 
            YesCount = 0;
            //saveした変数を削除
            PlayerPrefs.DeleteAll();

            kyotu.rrCount=0;

            kyotu.ReadMePanelCount = 0;

            //フラグパネルの表示をm1_1にリセット
            kyotu.meidaiHensu = 0;

            //meidaiの内容false？？？true内容表示
            kyotu.BoolMeidai1_1 = true;//一番最初常にtrue
            kyotu.BoolMeidai1_2 = false;
            kyotu.BoolMeidai1_3 = false;
            kyotu.BoolMeidai1_4 = false;
            kyotu.BoolMeidai1_5 = false;
            kyotu.BoolMeidai1_6 = false;

            //フラグ図で一番↓meidaiの証明　内容false？？？true内容表示 フラグ↓
            kyotu.BoolShomeiMeidai1_1 = false;
            kyotu.BoolShomeiMeidai1_2 = false;
            kyotu.BoolShomeiMeidai1_3 = false;
            kyotu.BoolShomeiMeidai1_4 = false;
            kyotu.BoolShomeiMeidai1_5 = false;
            kyotu.BoolShomeiMeidai1_6 = false;

            //フラッグの内容　false　？？？：true　内容
            kyotu.BoolKouri1 = false;
            kyotu.BoolKouri3 = false;
            kyotu.BoolKouri4 = false;
            kyotu.BoolKouri5 = false;

            kyotu.BoolKoujun1 = false;
            kyotu.BoolKoujun2 = false;
            kyotu.BoolKoujun3 = false;

            kyotu.BoolTeigi1 = false;
            kyotu.BoolTeigi15 = true;//一番最初常にtrue

            //フラグパネルの↓証明のtupを表示させるか否かを判定するプログラム
            kyotu.tupBoolShomeiMeidai1_1 = false;
            kyotu.tupBoolShomeiMeidai1_2 = false;
            kyotu.tupBoolShomeiMeidai1_3 = false;
            kyotu.tupBoolShomeiMeidai1_4 = false;
            kyotu.tupBoolShomeiMeidai1_5 = false;
            kyotu.tupBoolShomeiMeidai1_6 = false;

            //meidaipanel右上の点滅tupを表示させるか meidaipanelで使うtup
            //H_99_61_MokujiQuetion、で使う
            kyotu.TupBoolMeidai1_1 = true;//一番最初常にtrue
            kyotu.TupBoolMeidai1_2 = false;
            kyotu.TupBoolMeidai1_3 = false;
            kyotu.TupBoolMeidai1_4 = false;
            kyotu.TupBoolMeidai1_5 = false;
            kyotu.TupBoolMeidai1_6 = false;

            //panel右上の点滅tupを表示させるか
            //H_99_62_FlagQuetion、で使う
            kyotu.TupKouri1 = false;
            kyotu.TupKouri3 = false;
            kyotu.TupKouri4 = false;
            kyotu.TupKouri5 = false;

            kyotu.TupKoujun1 = false;
            kyotu.TupKoujun2 = false;
            kyotu.TupKoujun3 = false;

            kyotu.TupTeigi1 = false;
            kyotu.TupTeigi15 = true;//一番最初常にtrue


            

            kyotu.tuduki = false;


            //k7オブジェクトを直接onoff
            AutoSavePanel.SetActive(false);


        }

        if (kyotu.tuduki == false)
        {
            StartButtonText.GetComponent<TextMeshProUGUI>().text = "START";
        }
        else 
        {
            StartButtonText.GetComponent<TextMeshProUGUI>().text = "CONTINUE";
        }
        //Title.GetComponent<TextMeshProUGUI>().enabled = kyotuEla.tenmetuOnOff;//ok

        //Debug.Log("H_99_60_StartPanelControll>Title:::"+kyotu.tuduki);
    }
    public void onClickStartButton() 
    {
        //Debug.Log("H_99_60_StartPanelControll>Title:::");
        //start画面である９９でゲーム終了なら目次へ
        if(PlayerPrefs.GetInt("mainCameraPosi", 0) == 99) 
        {
            kyotu.mainCameraPosi = 0;
        }
        else //その他なら、終了時にsaveされたmaincamerapujiへ
        {
            kyotu.mainCameraPosi = PlayerPrefs.GetInt("mainCameraPosi", 0);
        }
        
    }
    public void onClickSaveButton() 
    {
        //k7オブジェクトを直接onoff
        AutoSavePanel.SetActive(true);

    }
    public void onClickButtonNo() 
    {
        YesCount = 0;
        //k7オブジェクトを直接onoff
        AutoSavePanel.SetActive(false);
    }
    public void onClickButtonYes()
    {
        YesCount++;
        //Debug.Log("H_99_60_StartPanelControll>YesCount:::" + YesCount);
    }
}
