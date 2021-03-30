using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;
//k7 textmeshpro を使う場合
using TMPro;

public class hTestKikaSaveTestNumber : MonoBehaviour
{
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    // Start is called before the first frame update

    void Start()
    {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        text.text = "変更sｓｓｓｓｓ";
    }

    // Update is called once per frame
    void Update()
    {
        //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
        //text.text = "変更sｓｓｓｓｓ";
    }
}
