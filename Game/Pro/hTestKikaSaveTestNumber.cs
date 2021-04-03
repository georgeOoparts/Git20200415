using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//k7_1:Imageコンポーネントを使う
using UnityEngine.UI;

public class hTestKikaSaveTestNumber : MonoBehaviour
{
    //k2_1:どこかに書かれている。Textというクラスを扱うための変数を作成
    Text text;
    // Start is called before the first frame update

    public static int i = 0;

    void Start()
    {
        //k2_1_1:Textをこのオブジェクトで使うためのおまじない
        text = this.gameObject.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //k0003_3:一瞬左クリックダウン入力されたか出力０１
        if (Input.GetMouseButtonUp(0)) 
        {
            //Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

            //if (aCollider2d)
            //{
            //    GameObject obj = aCollider2d.transform.gameObject;
            //    Debug.Log(obj.name);
            //}
            Debug.Log("Number ReserNumver:" + hTestKikaSaveTestReset.j);

            Debug.Log("Number Click" + hTestKikaSaveTestReset.click);
            if (hTestKikaSaveTestReset.j == 1)
            {
                hTestKikaSaveTestReset.j = 0;
                Debug.Log("Number click true kenshutu ");
            }
            else
            {
                
                i++;

                //k2_1_1_1:text.text = "・・・ "でTEXTのないよう変更。
                text.text = "Number:" + i;
                Debug.Log("Number Number" + i);
                //hTestKikaSaveTestReset.click = true;
            }

        }
        
    }

}
