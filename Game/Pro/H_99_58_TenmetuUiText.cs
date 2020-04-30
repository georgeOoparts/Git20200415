using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;

public class H_99_58_TenmetuUiText : MonoBehaviour
{
    //canvas＞rrpanel＞readmepanelというtextuiを点滅表示させるプログラム
    //アタッチ　canvas＞rrpanel＞readmepanel 
    RectTransform rt;
    void Start()
    {
        //k7_1_1:オブジェを存在するけど見えなくする。
        this.gameObject.GetComponent<Text>().enabled = false;
        
        
        Debug.Log("TenmetuUiText");   
    }

    // Update is called once per frame
    void Update()
    {

    }
}
