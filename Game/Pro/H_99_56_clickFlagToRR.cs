using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_56_clickFlagToRR : MonoBehaviour
{
    //このプログラムアタッチ＞flagpanel>moveflagpanel

    public H_99_01_kyoutuHensu kyotu;

    public　T0020M_mojiHonban mojiHonban;//アタッチ＞UIオブジェcanvasworld＞UIオブジェtextpanel


    //longTupを反応させないための処理に使うストップウォッチ
    //k6_1:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
    = new System.Diagnostics.Stopwatch();

    //k6_1_1:何秒たったかを変数elapseに入れる：update内に入れる-------
    ////?
    private float elapse;
    //0.15秒以上タップしていると、ボタンを押しているのが無効になる
    public float tupTime = 0.15f;
    //タップした場所と違うところでupするとボタンを押しているのが無効になる。
    //そのための座標を入れる変数
    Vector3 down;
    Vector3 up;

    void Start()
    {
        Debug.Log("H_99_56_clickFlagToRR>start::kyotu.meidaiHensu::" + kyotu.meidaiHensu
             + "kyotu.mainCameraPosi::" + kyotu.mainCameraPosi
             + "kyotu.rrCount::" + kyotu.rrCount
             + "kyotu.mojiSwitch::" + kyotu.mojiSwitch
             + "kyotu.MCount::" + kyotu.MCount
             );
    }

    // Update is called once per frame
    void Update()
    {
        elapse = (float)stopwatch.Elapsed.TotalSeconds;


        //tupTimeHantei = false;
        if (Input.GetMouseButtonDown(0))
        {
            //k6_1_1_2:ストップウォッチの時間をリセット
            stopwatch.Reset();
            //k6_1_1_1:ストップウォッチスタート
            stopwatch.Start();

            down = Input.mousePosition;
        }


        if (Input.GetMouseButtonUp(0))
        {
            stopwatch.Stop();
            up = Input.mousePosition;
        }

        if (boolClick1_1_2)
        {
            //tupUpとtupDownが同じ位置　かつ　タップの時間が一定以下ならば
            if ((up == down) && (elapse <= tupTime))
            {
                //T0002M_kyotuHensu.meidaiNumber = 0;
                //T0002M_kyotuHensu.cameraPosiNumber = 1;

                kyotu.mainCameraPosi = 2;
                //kyotu.meidaiHensu = 0;
                
                kyotu.rrCount = 0;
                kyotu.mojiSwitch = 2;
                kyotu.MCount = 1;

                mojiHonban.listReset();
            }

            boolClick1_1_2 = false;

            Debug.Log("H_99_56_clickFlagToRR>updatewwww::kyotu.meidaiHensu::" + kyotu.meidaiHensu
            + "kyotu.mainCameraPosi::" + kyotu.mainCameraPosi
            + "kyotu.rrCount::" + kyotu.rrCount
            + "kyotu.mojiSwitch::" + kyotu.mojiSwitch
            + "kyotu.MCount::" + kyotu.MCount
            );
        }
        else if (boolClick1_1_3)
        {
            //tupUpとtupDownが同じ位置　かつ　タップの時間が一定以下ならば
            if ((up == down) && (elapse <= tupTime))
            {
                //T0002M_kyotuHensu.meidaiNumber = 0;
                //T0002M_kyotuHensu.cameraPosiNumber = 1;

                kyotu.mainCameraPosi = 2;
            //kyotu.meidaiHensu = 0;

            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 1;
            kyotu.MCount = 0;

            mojiHonban.listReset();
            }

            boolClick1_1_3 = false;

            Debug.Log("H_99_56_clickFlagToRR>updatewwww::kyotu.meidaiHensu::" + kyotu.meidaiHensu
            + "kyotu.mainCameraPosi::" + kyotu.mainCameraPosi
            + "kyotu.rrCount::" + kyotu.rrCount
            + "kyotu.mojiSwitch::" + kyotu.mojiSwitch
            + "kyotu.MCount::" + kyotu.MCount
            );
        }

        //Debug.Log("H_99_56_clickFlagToRR>updatewwww::kyotu.meidaiHensu::"+ kyotu.meidaiHensu 
        //    + "kyotu.mainCameraPosi::"+ kyotu.mainCameraPosi
        //    + "kyotu.rrCount::" + kyotu.rrCount
        //    + "kyotu.mojiSwitch::" + kyotu.mojiSwitch
        //    + "kyotu.MCount::" + kyotu.MCount
        //);

        //Debug.Log("tesutdesuuu");
    }
    bool boolClick1_1_2 = false;
    bool boolClick1_1_3 = false;
    bool boolClick2 = false;
    bool boolClick3 = false;
    bool boolClick4 = false;
    bool boolClick5 = false;

    //uiボタンを押したとき起動するメソッド
    //canvas>MokujiPanel>MoveMokujiPanel>MokujiTextPanel1_1～6（このUIたちにインスぺで設定した）>TextMokuji1_1～6
    public void onClick1_1_2()
    {
        boolClick1_1_2 = true;
    }
    public void onClick1_1_3()
    {
        boolClick1_1_3 = true;
    }
    
}
