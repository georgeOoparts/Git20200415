﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_01_kyoutuHensu : MonoBehaviour
{
    //共通で使い呼び出されるオブジェ、変数はここでかんりするぜ。
    //k5_3_1: gameobject(メソッド、変数)を外部から呼び出す。
    //ヒエでアタッチ

    //elapseのためだけにstart関数を使い、
    //からのオブジェSWにこのプログラムをアタッチ


    //文字の内容と強調するプログラムH_99_13_mojiHonbanで使う
    //公理、公準、定義、meidaiのどの文字を表示させるかを決める
    //どのプログラムで数が増える？>canvasworld>textpanel>H_99_13_mojiHonban(右クリックで増える)
    //公理:0,公準:1,定義:2,meidai:3
    public int mojiSwitch = 3;


    //今、対象としているmeidaiを0から対応させる-----------
    //use　H_99_13_mojiHonban
    //どのプログラムで数が増える？>canvasworld>textpanel>H_99_13_mojiHonban(右クリックで増える)

    public int MCount = 0;

    //rrの何ターン目かをカウントする共通変数 -----------

    //use　H_99_16_sTriangleHenka、H_99_13_mojiHonban    
    //どのプログラムで数が増える？＞canvasworld>textpanel>T0020M_mojiHonban（左クリック）
    //どのプログラムで減る＞canvasworld>textpanel>T0020M_mojiHonban（右クリック0にリセット）

    public int rrCount=0;


    //maincameraがある位置を0～2で表す。----------------------
    public int mainCameraPosi = 0;


    ////meidaiの何がライン2（フラッグ図）にくるか決める変数0～5
    //canvas>mokujipanel>movemokujipanel>T0018M_clickChangeFN0で変更
    //meidaiパネルボタン１～６を押すと変更される
    public int meidaiHensu = 0;

    //canvas>readmepanelの処理のための変数。
    //canvas>readmepanel>H_99_59_ReadMeで使う
    public int ReadMePanelCount = 0;

    //canvas>readmepanel>H_99_59_ReadMe（この変数使用）でreadmepanelの表示が消された時のみ、
    //canvasworld＞UIオブジェtextpanel＞T0020M_mojiHonban（子の変数使用）でrrcountが+1されるようにする
    public bool rrCountLock = true;

    //canvas>startpanel>H_99_60_StartPanelControll
    //START画面がfalseならばStartPanelがSTART　TRUEならば　conteinue
    public bool tuduki = false;

    //meidaiの内容false？？？true内容表示
    public bool BoolMeidai1_1 = true;//一番最初常にtrue
    public bool BoolMeidai1_2 = false;
    public bool BoolMeidai1_3 = false;
    public bool BoolMeidai1_4 = false;
    public bool BoolMeidai1_5 = false;
    public bool BoolMeidai1_6 = false;

    //meidaiの内容false？？？true内容表示 フラグ↓
    public bool BoolShomeiMeidai1_1 = false;
    public bool BoolShomeiMeidai1_2 = false;
    public bool BoolShomeiMeidai1_3 = false;
    public bool BoolShomeiMeidai1_4 = false;
    public bool BoolShomeiMeidai1_5 = false;
    public bool BoolShomeiMeidai1_6 = false;

    
    //フラッグの内容　false　？？？：true　内容
    public bool BoolKouri1 = false;
    public bool BoolKouri3 = false;
    public bool BoolKouri4 = false;
    public bool BoolKouri5 = false;

    public bool BoolKoujun1 = false;
    public bool BoolKoujun2 = false;
    public bool BoolKoujun3 = false;

    public bool BoolTeigi1 = false;
    public bool BoolTeigi15 = true;//一番最初常にtrue
    
    //フラグパネルの↓証明のtupを表示させるか否かを判定するプログラム
    public bool tupBoolShomeiMeidai1_1 = false;
    public bool tupBoolShomeiMeidai1_2 = false;
    public bool tupBoolShomeiMeidai1_3 = false;
    public bool tupBoolShomeiMeidai1_4 = false;
    public bool tupBoolShomeiMeidai1_5 = false;
    public bool tupBoolShomeiMeidai1_6 = false;

    //meidaipanel右上の点滅tupを表示させるか meidaipanelで使うtup
    //H_99_61_MokujiQuetion、で使う
    public bool TupBoolMeidai1_1 = true;//一番最初常にtrue
    public bool TupBoolMeidai1_2 = false;
    public bool TupBoolMeidai1_3 = false;
    public bool TupBoolMeidai1_4 = false;
    public bool TupBoolMeidai1_5 = false;
    public bool TupBoolMeidai1_6 = false;

    //panel右上の点滅tupを表示させるか
    //H_99_62_FlagQuetion、で使う
    public bool TupKouri1 = false;
    public bool TupKouri3 = false;
    public bool TupKouri4 = false;
    public bool TupKouri5 = false;

    public bool TupKoujun1 = false;
    public bool TupKoujun2 = false;
    public bool TupKoujun3 = false;

    public bool TupTeigi1 = false;
    public bool TupTeigi15 = true;//一番最初常にtrue

    //クリア後、最後のパネルをmaincameraposi　0に表示させるための変数
    //canvas>mokujipanel＞LastPanelをmaincameraposi　0に表示させるか否かのbool
    //H_99_66_LastButtonScriptで使う
    public bool LastPanelHyouji = false;
    //LastPanelのテキスト内容を変更させるための変数
    public int LastPanelCount = 0;

    void Start()
    {
        
    }

    ////cameraTakasaY：カメラの真ん中から上半分のyジクの距離
    //public float cameraTakasaY = 5;
    ////upSpace：カメラの上から一番上のオブジェまでの距離
    //public float upSpace = 0.5f;

    ////ボタンタッチ移動と、横スワイプ移動がバグを起こさないため
    ////ボタン移動しているかどうかを表すへんすう。
    //public bool bottomMove = false;



    ////マズ　ライン１の目次のオブジェを定める
    //public GameObject mokuji;

    //public GameObject p1_1;
    //public GameObject p1_2;
    //public GameObject p1_3;
    //public GameObject p1_4;
    //public GameObject p1_5;
    //public GameObject p1_6;

    ////マズ　ライン2のmeidaiのオブジェを定める
    //public GameObject meidai;

    ////マズ　ライン2のmeidai1_1～meidai1_6のオブジェを定める
    //public GameObject meidai1_1;
    //public GameObject meidai1_2;
    //public GameObject meidai1_3;
    //public GameObject meidai1_4;
    //public GameObject meidai1_5;
    //public GameObject meidai1_6;

    ////マズ　ライン2のフラグ１のオブジェを定める
    //public GameObject p1_1_1;
    //public GameObject p1_1_2;
    //public GameObject p1_1_3;
    //public GameObject p1_1_4;
    //public GameObject p1_1_5;
    //public GameObject p1_1_6;

    ////マズ　ライン2のフラグ2のオブジェを定める
    //public GameObject p1_2_1;
    //public GameObject p1_2_2;
    //public GameObject p1_2_3;
    //public GameObject p1_2_4;
    //public GameObject p1_2_5;
    //public GameObject p1_2_6;
    //public GameObject p1_2_7;
    //public GameObject p1_2_8;
    //public GameObject p1_2_9;

    ////マズ　ライン2のフラグ3のオブジェを定める
    //public GameObject p1_3_1;
    //public GameObject p1_3_2;
    //public GameObject p1_3_3;
    //public GameObject p1_3_4;
    //public GameObject p1_3_5;
    //public GameObject p1_3_6;

    ////マズ　ライン2のフラグ4のオブジェを定める
    //public GameObject p1_4_1;
    //public GameObject p1_4_2;
    //public GameObject p1_4_3;
    //public GameObject p1_4_4;

    ////マズ　ライン2のフラグ5のオブジェを定める
    //public GameObject p1_5_1;
    //public GameObject p1_5_2;
    //public GameObject p1_5_3;
    //public GameObject p1_5_4;
    //public GameObject p1_5_5;
    //public GameObject p1_5_6;
    //public GameObject p1_5_7;

    ////マズ　ライン2のフラグ6のオブジェを定める
    //public GameObject p1_6_1;
    //public GameObject p1_6_2;
    //public GameObject p1_6_3;
    //public GameObject p1_6_4;
    //public GameObject p1_6_5;
    //public GameObject p1_6_6;
    //public int i = 0;
    private void Update()
    {
        

        //Debug.Log("kyoutuhensu::"+rrCount);
        //Debug.Log("H_99_01_kyoutuHensu>update::t2mMeidaiNumber::t2mCameraPosiNumber::"
        //    + T0002M_kyotuHensu.meidaiNumber + "::" + T0002M_kyotuHensu.cameraPosiNumber);
        //Debug.Log("H_99_01_kyoutuHensu>updatewwww::t2mMeidaiNumber::mainCameraPosi::"
        //    + T0002M_kyotuHensu.meidaiNumber + "::" + mainCameraPosi);
        //Debug.Log("H_99_01_kyoutuHensu>updatewwww::meidaiHensu::mainCameraPosi::"
        //    + meidaiHensu + "::" + mainCameraPosi);
    }


}
