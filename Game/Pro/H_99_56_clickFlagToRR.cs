using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_56_clickFlagToRR : MonoBehaviour
{
    //このプログラムアタッチ＞flagpanel>moveflagpanel

    public H_99_01_kyoutuHensu kyotu;

    public　T0020M_mojiHonban mojiHonban;//アタッチ＞UIオブジェcanvasworld＞UIオブジェtextpanel
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
        if (boolClick0)
        {
            //tupUpとtupDownが同じ位置　かつ　タップの時間が一定以下ならば
            //if ((up == down) && (elapse <= tupTime))
            //{
            //T0002M_kyotuHensu.meidaiNumber = 0;
            //T0002M_kyotuHensu.cameraPosiNumber = 1;
                
                kyotu.mainCameraPosi = 2;
                //kyotu.meidaiHensu = 0;
                
                kyotu.rrCount = 0;
                kyotu.mojiSwitch = 2;
                kyotu.MCount = 1;

                mojiHonban.listReset();
            //}

            boolClick0 = false;

            Debug.Log("H_99_56_clickFlagToRR>updatewwww::kyotu.meidaiHensu::" + kyotu.meidaiHensu
            + "kyotu.mainCameraPosi::" + kyotu.mainCameraPosi
            + "kyotu.rrCount::" + kyotu.rrCount
            + "kyotu.mojiSwitch::" + kyotu.mojiSwitch
            + "kyotu.MCount::" + kyotu.MCount
            );
        }
        else if (boolClick1)
        {
            //tupUpとtupDownが同じ位置　かつ　タップの時間が一定以下ならば
            //if ((up == down) && (elapse <= tupTime))
            //{
            //T0002M_kyotuHensu.meidaiNumber = 0;
            //T0002M_kyotuHensu.cameraPosiNumber = 1;

            kyotu.mainCameraPosi = 2;
            //kyotu.meidaiHensu = 0;

            kyotu.rrCount = 0;
            kyotu.mojiSwitch = 1;
            kyotu.MCount = 0;

            mojiHonban.listReset();
            //}

            boolClick1 = false;

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
    bool boolClick0 = false;
    bool boolClick1 = false;
    bool boolClick2 = false;
    bool boolClick3 = false;
    bool boolClick4 = false;
    bool boolClick5 = false;

    //uiボタンを押したとき起動するメソッド
    //canvas>MokujiPanel>MoveMokujiPanel>MokujiTextPanel1_1～6（このUIたちにインスぺで設定した）>TextMokuji1_1～6
    public void onClick0()
    {
        boolClick0 = true;
    }
    public void onClick1()
    {
        boolClick1 = true;
    }
}
