using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_62_FlagQuetion : MonoBehaviour
{
    //アタッチ　canvas＞flagpanel＞moveflagpanel
    //kyotu.BoolKoujun1～6　trueなら内容表示、falseなら???を表示
    //2020/05/12フラッグパネルの次のtupすべき所をtup表示する
    //2020/05/22フラッグパネルの次のtupすべき所をtup表示する　m1-6まで拡張
    public H_99_01_kyoutuHensu kyotu;
    public H_99_01B_kyotuElapse kyotuEla;

    public GameObject henkaTeigi15;
    public GameObject henkaKoujun1;
    public GameObject henkaKoujun3;
    public GameObject henkaKouri1;
    public GameObject henkaShomei1;

    //k0014_2 :プレハブ（画面のobjでもOK）を使う objにはりつけ
    public GameObject TupPrefab;

    private GameObject tupKouri1;
    private GameObject tupKouri3;
    private GameObject tupKouri4;
    private GameObject tupKouri5;

    private GameObject tupKoujun1;
    private GameObject tupKoujun2;
    private GameObject tupKoujun3;

    private GameObject tupTeigi1;
    private GameObject tupTeigi15;

    private GameObject tupShomeiM1;
    private GameObject tupShomeiM2;
    private GameObject tupShomeiM3;
    private GameObject tupShomeiM4;
    private GameObject tupShomeiM5;
    private GameObject tupShomeiM6;

    void Start()
    {
        //ここからフラグパネルm1_2のtupのためのオブジェ------------
        //プレハブからtupTeigi15を作る。点滅するtupと表示されるGameオブジェクト
        //k0014_2_1 :プレハブを使う
        tupTeigi15 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupTeigi15.transform.SetParent(henkaTeigi15.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupTeigi15.name = "ptupTeigi15";

        //プレハブからtupKoujun1を作る。点滅するtupと表示されるGameオブジェクトーーーー
        //k0014_2_1 :プレハブを使う
        tupKoujun1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKoujun1.transform.SetParent(henkaKoujun1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKoujun1.name = "ptupKoujun1";

        //プレハブからtupKoujun3を作る。点滅するtupと表示されるGameオブジェクトーーーーー
        //k0014_2_1 :プレハブを使う
        tupKoujun3 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKoujun3.transform.SetParent(henkaKoujun3.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKoujun3.name = "ptupKoujun3";

        //プレハブからtupKouri1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupKouri1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKouri1.transform.SetParent(henkaKouri1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKouri1.name = "ptupKouri1";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM1.transform.SetParent(henkaShomei1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM1.name = "ptupKoujun1";

        //ここからフラグパネルm1_2のtupのためのオブジェ------------

    }

    // Update is called once per frame
    void Update()
    {
        //表示するもの???か内容か
        ///まずはフラグm1-6まで
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
            henkaShomei1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            henkaShomei1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei1.GetComponent<Text>().text = "???";
            henkaShomei1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }



        //点滅するtupが表示されるか否か
        //使うGameオブジェクトはスタートでプレハブから作っている
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
