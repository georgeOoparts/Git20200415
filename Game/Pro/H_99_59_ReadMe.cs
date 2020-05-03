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
    //>kyotu.ReadMePanelCountが2で表示を消す

    //canvas＞rrpanel>TupReadMePanelの点滅制御をする
    //>kyotu.ReadMePanelCountが2で表示を消す

    //canvas＞rrpanel>TextReadMePanelがkyotu.ReadMePanelCountが2で表示を消す
    //>kyotu.ReadMePanelCountが2で表示を消す

    //canvas＞rrpanel>readmepanel
    public H_99_01_kyoutuHensu kyotu;

    //点滅処理のために呼び出す
    public H_99_01B_kyotuElapse kyotuela;

    public GameObject OkReadMePanel;

    public GameObject TupReadMePanel;

    public GameObject TextReadMePanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kyotu.ReadMePanelCount==0) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = true;
            
            //k7_1_1:オブジェを存在するけど見えなくする。
            TupReadMePanel.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = true;
        }
        else if (kyotu.ReadMePanelCount == 1) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = true;

            //k7_1_1:オブジェを存在するけど見えなくする。
            TupReadMePanel.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = true;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = true;
        }
        else 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。
            TupReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = false;
        }

        Debug.Log("H_99_59_ReadMe>update>kyotu.rrCountLock::" + kyotu.rrCountLock);

        //Debug.Log("H_99_59_ReadMe>update>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);

    }
    //0021_99_1:uiボタンを使う
    public void onClickReadMe() 
    {
        kyotu.ReadMePanelCount++;
        //Debug.Log("H_99_59_ReadMe>onClickReadMe>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);
    }

}
