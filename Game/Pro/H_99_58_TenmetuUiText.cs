using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;


public class H_99_58_TenmetuUiText : MonoBehaviour
{
    //現在使われていない
    
    //点滅処理のために呼び出す
    public H_99_01B_kyotuElapse kyotuela;
    
    //canvas＞rrpanel＞readmepanelというtextuiを点滅表示させるプログラム
    //アタッチ　canvas＞rrpanel＞readmepanel 
    void Start()
    {
        
        
        
        //Debug.Log("TenmetuUiText");   
    }

    // Update is called once per frame
    void Update()
    {
        //k7_1_1:オブジェを存在するけど見えなくする。
        this.gameObject.GetComponent<Text>().enabled = kyotuela.tenmetuOnOff;
    }
}
