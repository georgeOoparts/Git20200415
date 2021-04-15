using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;

public class hTestKikaSaveTestNumber : MonoBehaviour
{
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;

    public static int i = 0;

    void Start()
    {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();

        
        Debug.Log("start::"+PlayerPrefs.GetInt("saveNumer", 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        //k0003_3:一瞬左クリックダウン入力されたか出力０１
        if (Input.GetMouseButtonUp(0)) 
        {
            
            if (hTestKikaSaveTestReset.click == true)
            {
                hTestKikaSaveTestReset.click = false;
            }
            else
            {
                
                i++;
                //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
                text.text = "Number:" + i;
                
                PlayerPrefs.SetInt("saveNumer",i);

                PlayerPrefs.Save();
                
            }

        }
        
    }

}
