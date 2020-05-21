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

    public GameObject henkaTeigi15;
    public GameObject henkaKoujun1;
    public GameObject henkaKoujun3;
    public GameObject henkaKouri1;
    public GameObject henkaShoumei1;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject TupPrefab;

    private GameObject tupTeigi15;

    private GameObject tupKoujun1;

    void Start()
    {
        //k0014_2_1 :プレハブを使う
        tupTeigi15 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupTeigi15.transform.SetParent(henkaTeigi15.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupTeigi15.name = "ptupTeigi15";

        //k0014_2_1 :プレハブを使う
        tupKoujun1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKoujun1.transform.SetParent(henkaKoujun1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKoujun1.name = "ptupKoujun1";
        //Debug.Log("rerer"+ kyotu.BoolTeigi15);
    }

    // Update is called once per frame
    void Update()
    {
        //表示するもの???か内容か
        if (kyotu.BoolKoujun1 == true)
        {
            //Debug.Log("true");
            henkaKoujun1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            henkaKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else 
        {
            henkaKoujun1.GetComponent<Text>().text = "???";
            henkaKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolKoujun3 == true)
        {
            //Debug.Log("true");
            henkaKoujun3.GetComponent<Text>().text = "公準P-1\n円とは周と呼ばれる1つの線の"+"\n"+
            "境界で囲まれた平面図形であって" + "\n" +
            "その中にある1つの点から円周上" + "\n" +
            "の点に引かれた直線の長さが" + "\n" +
            "すべて等しいようなものである";
            henkaKoujun3.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKoujun3.GetComponent<Text>().text = "???";
            henkaKoujun3.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        
        if (kyotu.BoolKouri1 == true)
        {
            //Debug.Log("true");
            henkaKouri1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            henkaKouri1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKouri1.GetComponent<Text>().text = "???";
            henkaKouri1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_1 == true)
        {
            //Debug.Log("true");
            henkaShoumei1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            henkaShoumei1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShoumei1.GetComponent<Text>().text = "???";
            henkaShoumei1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }



        //点滅するtupが表示されるか否か
        if (kyotu.TupTeigi15==true) 
        {
            //点滅処理
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
