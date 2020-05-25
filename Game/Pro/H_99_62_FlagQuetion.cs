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

    public GameObject henkaKoujun2;
    public GameObject henkaKouri3;
    public GameObject henkaShomei2;

    public GameObject henkaShomei3;

    public GameObject henkaKouri4;
    public GameObject henkaShomei4;

    public GameObject henkaShomei5;//

    public GameObject henkaKouri5;
    public GameObject henkaShomei6;

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
        tupKoujun2 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKoujun2.transform.SetParent(henkaKoujun2.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKoujun2.name = "ptupKoujun2";

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

        //プレハブからtupKouri3を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupKouri3 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKouri3.transform.SetParent(henkaKouri3.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKouri3.name = "ptupKouri3";

        //プレハブからtupKouri4を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupKouri4 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKouri4.transform.SetParent(henkaKouri4.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKouri4.name = "ptupKouri4";

        //プレハブからtupKouri5を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupKouri5 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupKouri5.transform.SetParent(henkaKouri5.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupKouri5.name = "ptupKouri5";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM1 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM1.transform.SetParent(henkaShomei1.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM1.name = "ptupShomeiM1";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM2 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM2.transform.SetParent(henkaShomei2.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM2.name = "ptupShomeiM2";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM3 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM3.transform.SetParent(henkaShomei3.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM3.name = "ptupShomeiM3";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM4 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM4.transform.SetParent(henkaShomei4.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM4.name = "ptupShomeiM4";
        
        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM5 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM5.transform.SetParent(henkaShomei5.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM5.name = "ptupShomeiM5";

        //プレハブからtupShomeiM1を作る。点滅するtupと表示されるGameオブジェクト------------
        //k0014_2_1 :プレハブを使う
        tupShomeiM6 = Instantiate(TupPrefab) as GameObject;

        // k0014_2_1_1 :プレハブをキャンバスの子供にする()
        tupShomeiM6.transform.SetParent(henkaShomei6.GetComponent<Transform>(), false);

        //k0014_2_1_1: オブジェの名前を変化させる
        tupShomeiM6.name = "ptupShomeiM5";
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
        if (kyotu.BoolKoujun2 == true)
        {
            //Debug.Log("yomikomareteru");
            henkaKoujun2.GetComponent<Text>().text = "公準P-2\n" + "任意の直線を連続してのばすこと";
            henkaKoujun2.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKoujun2.GetComponent<Text>().text = "???";
            henkaKoujun2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolKoujun3 == true)
        {
            //Debug.Log("yomikomareteru");
            henkaKoujun3.GetComponent<Text>().text = "公準P-3\n"+"任意の中心と任意の半径の円を描くこと";
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
            henkaKouri1.GetComponent<Text>().text = "公理A-1\n同じものに等しいものは互いに等しい";
            henkaKouri1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKouri1.GetComponent<Text>().text = "???";
            henkaKouri1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolKouri3 == true)
        {
            //Debug.Log("true");
            henkaKouri3.GetComponent<Text>().text = "公理A-3\n"+"等しいものから等しいものを引いた差は互いに等しい";
            henkaKouri3.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKouri3.GetComponent<Text>().text = "???";
            henkaKouri3.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolKouri5 == true)
        {
            //Debug.Log("true");
            henkaKouri5.GetComponent<Text>().text = "公理A-5\n" + "全体は部分より大きい";
            henkaKouri5.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaKouri5.GetComponent<Text>().text = "???";
            henkaKouri5.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }

        if (kyotu.BoolShomeiMeidai1_1 == true)
        {
            //Debug.Log("true");
            henkaShomei1.GetComponent<Text>().text = "命題1-1　　　証明\n与えられた直線を一辺とする\n正三角形を作図すること";
            henkaShomei1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei1.GetComponent<Text>().text = "???";
            henkaShomei1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_2 == true)
        {
            //Debug.Log("true");
            henkaShomei2.GetComponent<Text>().text = "命題1-2　　　証明\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            henkaShomei2.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei2.GetComponent<Text>().text = "???";
            henkaShomei2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_3 == true)
        {
            //Debug.Log("true");
            henkaShomei3.GetComponent<Text>().text = "命題1-3　　　証明\n長さが異なる2つの直線が与えられたとき、長い方から短い方の　長さを切り取ること。";
            henkaShomei3.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei3.GetComponent<Text>().text = "???";
            henkaShomei3.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_4 == true)
        {
            //Debug.Log("true");
            henkaShomei4.GetComponent<Text>().text = "命題1-4　　　証明\n" +
            "2つの三角形において"+"\n"+
            "2つの辺がそれぞれ等しく" +"\n"+
            "その2辺に挟まれる角も等しいならば、底辺も等しく" +"\n"+
            "2つの三角形は等しい" + "\n" +
            "そして、残りの角もそれぞれ等しい";
            henkaShomei4.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei4.GetComponent<Text>().text = "???";
            henkaShomei4.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_5 == true)
        {
            //Debug.Log("true");
            henkaShomei5.GetComponent<Text>().text = "命題1-5　　　証明\n" + "2等辺三角形の底辺上の２つの角は互いに等しい、そして、等辺を延長してできる底辺下の2つの角も互いに等しい";
            henkaShomei5.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei5.GetComponent<Text>().text = "???";
            henkaShomei5.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        if (kyotu.BoolShomeiMeidai1_6 == true)
        {
            //Debug.Log("true");
            henkaShomei6.GetComponent<Text>().text = "命題1-6　　　証明\n" + "三角形の２つの角が等しいしいならば、それらに対する2つの辺も互いに等しい。";
            henkaShomei6.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            henkaShomei6.GetComponent<Text>().text = "???";
            henkaShomei6.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        //点滅するtupが表示されるか否か
        //使うGameオブジェクトはスタートでプレハブから作っている
        if (kyotu.TupKouri1 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri1.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri1.GetComponent<Text>().enabled = false;
        }
        if (kyotu.TupKouri3 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri3.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri3.GetComponent<Text>().enabled = false;
        }
        if (kyotu.TupKouri4 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri4.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri4.GetComponent<Text>().enabled = false;
        }
        if (kyotu.TupKouri5 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri5.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKouri5.GetComponent<Text>().enabled = false;
        }
        //if (kyotu.TupKouri5 == true)
        //{
        //    //k7_1_1:オブジェを存在するけど見えなくする。
        //    tupKouri5.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        //}
        //else
        //{
        //    //k7_1_1:オブジェを存在するけど見えなくする。
        //    tupKouri5.GetComponent<Text>().enabled = false;
        //}

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
        if (kyotu.TupKoujun2 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun2.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun2.GetComponent<Text>().enabled = false;//
        }
        if (kyotu.TupKoujun3 == true)
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun3.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupKoujun3.GetComponent<Text>().enabled = false;
        }

        //if (kyotu.TupTeigi1 == true)
        //{
        //    //点滅処理
        //    tupTeigi1.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        //}
        //else
        //{
        //    //k7_1_1:オブジェを存在するけど見えなくする。
        //    tupTeigi1.GetComponent<Text>().enabled = false;
        //}
        if (kyotu.TupTeigi15 == true)
        {
            //点滅処理
            tupTeigi15.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupTeigi15.GetComponent<Text>().enabled = false;
        }

        if (kyotu.tupBoolShomeiMeidai1_1 == true)
        {
            //点滅処理
            tupShomeiM1.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM1.GetComponent<Text>().enabled = false;
        }
        if (kyotu.tupBoolShomeiMeidai1_2 == true)
        {
            //点滅処理
            tupShomeiM2.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM2.GetComponent<Text>().enabled = false;
        }
        if (kyotu.tupBoolShomeiMeidai1_3 == true)
        {
            //点滅処理
            tupShomeiM3.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM3.GetComponent<Text>().enabled = false;
        }
        if (kyotu.tupBoolShomeiMeidai1_4 == true)
        {
            //点滅処理
            tupShomeiM4.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM4.GetComponent<Text>().enabled = false;
        }
        if (kyotu.tupBoolShomeiMeidai1_5 == true)
        {
            //点滅処理
            tupShomeiM5.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM5.GetComponent<Text>().enabled = false;
        }
        if (kyotu.tupBoolShomeiMeidai1_6 == true)
        {
            //点滅処理
            tupShomeiM6.GetComponent<Text>().enabled = kyotuEla.tenmetuOnOff;
        }
        else
        {
            //k7_1_1:オブジェを存在するけど見えなくする。
            tupShomeiM6.GetComponent<Text>().enabled = false;
        }
        //Debug.Log("H_99_01_kyoutuHensu>update::rrCount::" + kyotu.rrCount);
    }
}
