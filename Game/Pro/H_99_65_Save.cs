﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_65_Save : MonoBehaviour
{
    public H_99_01_kyoutuHensu　kyotu;

    //int save = 0;



    //public bool SaveBool = false;
    void Start()
    {
        kyotu.rrCount = PlayerPrefs.GetInt("rrCount", 0);
        //SaveBool = H_99_63_SaveData.GetBool("saveBool", false);
        //kyotu.rrCountLock = H_99_63_SaveData.GetBool("rrCountLock", true);
        kyotu.ReadMePanelCount= PlayerPrefs.GetInt("ReadMePanelCount", 0);
        
        //tup表示させるか否かのbool保存
        kyotu.TupBoolMeidai1_1 = H_99_63_SaveData.GetBool("BoolMeidai1_1", true);
        kyotu.TupTeigi15 = H_99_63_SaveData.GetBool("TupTeigi15", true);
        kyotu.TupKoujun1 = H_99_63_SaveData.GetBool("TupKoujun1", true);




        //内容を表示させるか？？？を決めるboolのsave
        ///meidaiパネルの表示　内容表示か？？？かのboolのsave
        kyotu.BoolMeidai1_1 = H_99_63_SaveData.GetBool("BoolMeidai1_1", true);//一番最初常にtrue
        kyotu.BoolMeidai1_2 = H_99_63_SaveData.GetBool("BoolMeidai1_2", false);
        kyotu.BoolMeidai1_3 = H_99_63_SaveData.GetBool("BoolMeidai1_3", false);
        kyotu.BoolMeidai1_4 = H_99_63_SaveData.GetBool("BoolMeidai1_4", false);
        kyotu.BoolMeidai1_5 = H_99_63_SaveData.GetBool("BoolMeidai1_5", false);
        kyotu.BoolMeidai1_6 = H_99_63_SaveData.GetBool("BoolMeidai1_6", false);

        ///フラグパネルの???か内容か決めるboolの保存
        kyotu.BoolTeigi15 = H_99_63_SaveData.GetBool("BoolTeigi15", true);//一番最初　常にtrue
        kyotu.BoolKoujun1 = H_99_63_SaveData.GetBool("BoolKoujun1", false);
        //Debug.Log("H_99_65_Save>start::BoolKoujun1::" + kyotu.BoolKoujun1) ;

        kyotu.BoolKoujun3 = H_99_63_SaveData.GetBool("BoolKoujun3", false);
        kyotu.BoolKouri1 = H_99_63_SaveData.GetBool("BoolKouri1", false);
        kyotu.BoolShomeiMeidai1_1 = H_99_63_SaveData.GetBool("kyotu.BoolShomeiMeidai1_1", false);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("H_99_65_Save>Update::savebool::" + SaveBool) ;
        //Debug.Log("H_99_65_Save>Update::rrCountLock::" + kyotu.rrCountLock) ; 
        //Debug.Log("H_99_65_Save>Update::kyotu.ReadMePanelCount::" + kyotu.ReadMePanelCount);

        if (Input.GetMouseButtonDown(0)) 
        {
            //save++;
            //SaveBool = true;
            //Debug.Log(SaveBool);


        }
        else if (Input.GetMouseButtonDown(1)) 
        {
            //SaveBool = false;
            //Debug.Log(SaveBool);
        }

    }
    void OnDestroy()
    {
        // スコアを保存
        //Debug.Log("cameraposiFirst::"+kyotu.mainCameraPosi);
        PlayerPrefs.SetInt("rrCount", kyotu.rrCount);
        PlayerPrefs.SetInt("mainCameraPosi",kyotu.mainCameraPosi);
        //Debug.Log("cameraposi::"+PlayerPrefs.GetInt("mainCameraPosi", 0));
        //変数名が分かりにくいが、readmepanel表示にするか決めるbool変数
        //H_99_63_SaveData.SetBool("rrCountLock", kyotu.rrCountLock);
        PlayerPrefs.SetInt("ReadMePanelCount", kyotu.ReadMePanelCount);
        
        H_99_63_SaveData.SetBool("TupBoolMeidai1_1", kyotu.TupBoolMeidai1_1);
        H_99_63_SaveData.SetBool("TupTeigi15", kyotu.TupTeigi15);
        H_99_63_SaveData.SetBool("TupKoujun1", kyotu.TupKoujun1);


        //kyotu.meidai2～6までをsave
        H_99_63_SaveData.SetBool("BoolMeidai1_2", kyotu.BoolMeidai1_2);
        H_99_63_SaveData.SetBool("BoolMeidai1_3", kyotu.BoolMeidai1_3);
        H_99_63_SaveData.SetBool("BoolMeidai1_4", kyotu.BoolMeidai1_4);
        H_99_63_SaveData.SetBool("BoolMeidai1_5", kyotu.BoolMeidai1_5);
        H_99_63_SaveData.SetBool("BoolMeidai1_6", kyotu.BoolMeidai1_6);

        //???か内容か
        H_99_63_SaveData.SetBool("BoolTeigi15", kyotu.BoolTeigi15);

        H_99_63_SaveData.SetBool("BoolKoujun1", kyotu.BoolKoujun1);

        H_99_63_SaveData.SetBool("BoolKoujun3", kyotu.BoolKoujun3);

        H_99_63_SaveData.SetBool("BoolKouri1", kyotu.BoolKouri1);
        
        H_99_63_SaveData.SetBool("kyotu.BoolShomeiMeidai1_1", kyotu.BoolShomeiMeidai1_1);

        //H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    //private void OnApplicationQuit()
    //{
    //    PlayerPrefs.SetInt("rrCount",kyotu.rrCount);
    //    //H_99_63_SaveData.SetBool("saveBool", SaveBool);


    //}
}
