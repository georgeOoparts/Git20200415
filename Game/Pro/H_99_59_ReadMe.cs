using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class H_99_59_ReadMe : MonoBehaviour
{
    //canvas＞rrpanel>readmepanelをタップした時の処理を制御するプログラム
    //canvas＞rrpanel>readmepanelにアタッチ
    //canvas＞rrpanel>readmepanelをtupするたびにkyotu.ReadMePanelCountを１づつ増やす
    //kyotu.ReadMePanelCountが１になった時canvas＞rrpanel>readmepanel>OkReadMePanelを表示
    //canvas＞rrpanel>TupReadMePanelの点滅制御をする
    public H_99_01_kyoutuHensu kyotu;

    //点滅処理のために呼び出す
    public H_99_01B_kyotuElapse kyotuela;

    public GameObject OkReadMePanel;

    public GameObject TupReadMePanel;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //k7_1_1:オブジェを存在するけど見えなくする。
        TupReadMePanel.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;

        if (kyotu.ReadMePanelCount>=1) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = true;
        }
        Debug.Log("H_99_59_ReadMe>update>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);

    }
    //0021_99_1:uiボタンを使う
    public void onClickReadMe() 
    {
        kyotu.ReadMePanelCount++;
        Debug.Log("H_99_59_ReadMe>onClickReadMe>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);
    }

}
