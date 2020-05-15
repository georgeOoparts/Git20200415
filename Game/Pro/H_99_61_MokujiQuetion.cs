using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class H_99_61_MokujiQuetion : MonoBehaviour
{
    //目次パネルの？？？表示を制御するプログラム
    //kyotu.BoolMeidai1_2～6がfalseのとき???、trueの時　内容表示にする
    //アタッチ　canvas＞mokujipanel＞movemokujipanel
    
    //2020/05/12　次のtup制御追加　次にtupすべきパネルにtup表示する
    public H_99_01_kyoutuHensu kyotu;

    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject TextMokuji1_1;
    public GameObject TextMokuji1_2;
    public GameObject TextMokuji1_3;
    public GameObject TextMokuji1_4;
    public GameObject TextMokuji1_5;
    public GameObject TextMokuji1_6;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject TupPrefab;
    //プレハブを代入したオブジェ
    private GameObject tupMokuji1_1;

    private GameObject tupMokuji1_2;

    private GameObject tupMokuji1_3;
    private GameObject tupMokuji1_4;
    private GameObject tupMokuji1_5;
    private GameObject tupMokuji1_6;

    void Start()
    {
        //k0014_2_1 :プレハブを使う
        tupMokuji1_1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupMokuji1_1.transform.SetParent(TextMokuji1_1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupMokuji1_1.name = "ptupMokuji1_1";

        //k0014_2_1 :プレハブを使う
        tupMokuji1_2 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupMokuji1_2.transform.SetParent(TextMokuji1_2.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupMokuji1_2.name = "ptupMokuji1_2";
    }

    // Update is called once per frame
    void Update()
    {
        //表示を？？？か内容か
        
        if(kyotu.BoolMeidai1_2 == true)
        {
            //Debug.Log("true");
            TextMokuji1_2.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            //Debug.Log("false");

            TextMokuji1_2.GetComponent<Text>().text = "???";
            TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolMeidai1_3 == true)
        {
            //Debug.Log("true");
            TextMokuji1_3.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_3.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            //Debug.Log("false");

            TextMokuji1_3.GetComponent<Text>().text = "???";
            TextMokuji1_3.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolMeidai1_4 == true)
        {
            //Debug.Log("true");
            TextMokuji1_4.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_4.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            //Debug.Log("false");

            TextMokuji1_4.GetComponent<Text>().text = "???";
            TextMokuji1_4.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolMeidai1_5 == true)
        {
            //Debug.Log("true");
            TextMokuji1_5.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_5.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            //Debug.Log("false");

            TextMokuji1_5.GetComponent<Text>().text = "???";
            TextMokuji1_5.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolMeidai1_6 == true)
        {
            //Debug.Log("true");
            TextMokuji1_6.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_6.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            //Debug.Log("false");

            TextMokuji1_6.GetComponent<Text>().text = "???";
            TextMokuji1_6.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }




        //右上tup　を表示したり、しなかったり
        if (kyotu.TupBoolMeidai1_1 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupMokuji1_1.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupMokuji1_1.GetComponent<Text>().enabled = false;
        }

        if (kyotu.TupBoolMeidai1_2 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupMokuji1_2.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupMokuji1_2.GetComponent<Text>().enabled = false;
        }

        //TextMokuji1_2.GetComponent<Text>().text = "???";
        //TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

        //Debug.Log("canvas>mokujipanel>movemokujipanel>H_99_61_MokujiQuetion::boolmeidai::"+kyotu.BoolMeidai1_2);
    }
}
