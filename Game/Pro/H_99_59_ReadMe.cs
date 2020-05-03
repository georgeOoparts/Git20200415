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
    public H_99_01_kyoutuHensu kyotu;
    // Start is called before the first frame update
    public GameObject OkReadMePanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
