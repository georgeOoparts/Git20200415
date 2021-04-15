using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;

public class hTestKikaSaveTestReset : MonoBehaviour
{
    
    
    public GameObject num;
    public GameObject bo;

    public static bool click=false;

    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text textNum;
    Text textBo;
    void Start()
    {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        textNum = num.GetComponent<Text>();
        textBo = bo.GetComponent<Text>();
        //int k= PlayerPrefs.GetInt("saveNumber");
        //Debug.Log(k);
    }

    
    public void resetTest() 
    {
        click = true;

        hTestKikaSaveTestNumber.i = 1;
        hTestKikaSaveTestBool.tf = false;
        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        textNum.text = "Number:" + hTestKikaSaveTestNumber.i;
        textBo.text = "Bool:" + hTestKikaSaveTestBool.tf;


    }

    
}
