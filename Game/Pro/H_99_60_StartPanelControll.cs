﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//k7 textmeshpro を使う場合
using TMPro;

public class H_99_60_StartPanelControll : MonoBehaviour
{
    public H_99_01B_kyotuElapse kyotuEla;
    public GameObject Title;
    void Start()
    {
        //k7 textmeshpro を使う場合　直接enableを記述しなければならない
        //Title.GetComponent<TextMeshProUGUI>().enabled = kyotuEla.tenmetuOnOff;//ok
        
    }

    // Update is called once per frame
    void Update()
    {
        Title.GetComponent<TextMeshProUGUI>().enabled = kyotuEla.tenmetuOnOff;//ok

        Debug.Log("H_99_60_StartPanelControll>Title:::"+Title.name);
    }
}