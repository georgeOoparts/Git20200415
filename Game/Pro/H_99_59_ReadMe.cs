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


    //20200512点滅tupをプレハブ化

    //canvas＞rrpanel>readmepanel
    public H_99_01_kyoutuHensu kyotu;

    //点滅処理のために呼び出す
    public H_99_01B_kyotuElapse kyotuela;

    public GameObject OkReadMePanel;

    //public GameObject TupReadMePanel;

    public GameObject TextReadMePanel;


    
    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject PreTupReadMePanel;

    private GameObject pTupReadMePanel;

    void Start()
    {
        //k0014_2_1 :プレハブを使う
        pTupReadMePanel = Instantiate(PreTupReadMePanel) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        pTupReadMePanel.transform.SetParent(this.gameObject.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        pTupReadMePanel.name = "pTupReadMePanel";

    }

    // Update is called once per frame
    void Update()
    {
        //if (kyotu.rrCountLock == false) 
        //{
        //    //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
        //    this.gameObject.GetComponent<Image>().enabled = false;

        //    //k7_1_1:オブジェを存在するけど見えなくする。
        //    pTupReadMePanel.GetComponent<Text>().enabled = false;

        //    //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
        //    OkReadMePanel.GetComponent<Text>().enabled = false;

        //    //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
        //    TextReadMePanel.GetComponent<Text>().enabled = false;
        //}
        
        
        if (kyotu.ReadMePanelCount==0) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = true;

            //k7_1_1:オブジェを存在するけど見えなくする。
            pTupReadMePanel.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = true;

            kyotu.rrCountLock = true;
        }
        else if (kyotu.ReadMePanelCount == 1) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = true;

            //k7_1_1:オブジェを存在するけど見えなくする。
            pTupReadMePanel.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = true;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = true;

            kyotu.rrCountLock = true;
        }
        else if (kyotu.ReadMePanelCount >= 2)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。//uipanelの時
            this.gameObject.GetComponent<Image>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。
            pTupReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            OkReadMePanel.GetComponent<Text>().enabled = false;

            //k7_1_1:オブジェを存在するけど見えなくする。//uitextの時
            TextReadMePanel.GetComponent<Text>().enabled = false;
            //これがfalseになることでrrcount進む
            kyotu.rrCountLock = false;

            
        }

        //Debug.Log("H_99_59_ReadMe>update>kyotu.rrCountLock::" + kyotu.rrCountLock+ ":;ReadMePanelCount::" + kyotu.ReadMePanelCount);

        //Debug.Log("H_99_59_ReadMe>update>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);

    }
    //0021_99_1:uiボタンを使う
    public void onClickReadMe() 
    {
        kyotu.ReadMePanelCount++;
        //Debug.Log("H59>click");
        //Debug.Log("H_99_59_ReadMe>onClickReadMe>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);
    }

}
