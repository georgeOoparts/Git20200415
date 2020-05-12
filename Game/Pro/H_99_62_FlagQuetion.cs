using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_62_FlagQuetion : MonoBehaviour
{
    //アタッチ　canvas＞flagpanel＞moveflagpanel
    //kyotu.BoolKoujun1～6　trueなら内容表示、falseなら???を表示
    //2020/05/12フラッグパネルの次のtupすべき所をtup表示する
    public H_99_01_kyoutuHensu kyotu;
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject BoolTeigi15;
    public GameObject BoolKoujun1;
    public GameObject BoolKoujun3;
    public GameObject BoolKouri1;
    public GameObject BoolShoumei1;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject TupPrefab;

    private GameObject tupTeigi15;

    private GameObject tupKoujun1;

    void Start()
    {
        //k0014_2_1 :プレハブを使う
        tupTeigi15 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupTeigi15.transform.SetParent(BoolTeigi15.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupTeigi15.name = "ptupTeigi15";

        //k0014_2_1 :プレハブを使う
        tupKoujun1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKoujun1.transform.SetParent(BoolKoujun1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKoujun1.name = "ptupKoujun1";
        //Debug.Log("rerer"+ kyotu.BoolTeigi15);
    }

    // Update is called once per frame
    void Update()
    {
        if (kyotu.BoolKoujun1 == true)
        {
            //Debug.Log("true");
            BoolKoujun1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            BoolKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else 
        {
            BoolKoujun1.GetComponent<Text>().text = "???";
            BoolKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }

        if (kyotu.TupTeigi15==true) 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupTeigi15.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else 
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupTeigi15.GetComponent<Text>().enabled = false;
        }
        if (kyotu.TupKoujun1 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun1.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun1.GetComponent<Text>().enabled = false;
        }


        //Debug.Log("H_99_01_kyoutuHensu>update::rrCount::" + kyotu.rrCount);
    }
}
