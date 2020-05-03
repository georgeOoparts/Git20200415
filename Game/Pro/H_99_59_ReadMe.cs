using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_59_ReadMe : MonoBehaviour
{
    //canvas＞rrpanel>readmepanelをタップした時の処理を制御するプログラム
    //canvas＞rrpanel>readmepanelにアタッチ
    public H_99_01_kyoutuHensu kyotu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("H_99_59_ReadMe>update>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount); ;

    }
    //0021_99_1:uiボタンを使う
    public void onClickReadMe() 
    {
        kyotu.ReadMePanelCount++;
        Debug.Log("H_99_59_ReadMe>onClickReadMe>kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);
    }
}
