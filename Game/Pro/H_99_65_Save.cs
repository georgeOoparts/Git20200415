using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_65_Save : MonoBehaviour
{
    public H_99_01_kyoutuHensu　kyotu;

    //int save = 0;



    //public bool SaveBool = false;
    void Start()
    {
        
        //前にgameをやめた場所の記憶をロード
        kyotu.rrCount = PlayerPrefs.GetInt("rrCount", 0);
        //一番最初のカメラの位置は99スタートであることに注意。最初から前回のカメラ位置をロードしない。

        kyotu.mojiSwitch = PlayerPrefs.GetInt("mojiSwitch", 0);
        kyotu.MCount= PlayerPrefs.GetInt("MCount", 0);
        kyotu.meidaiHensu = PlayerPrefs.GetInt("meidaiHensu", 0);
        //SaveBool = H_99_63_SaveData.GetBool("saveBool", false);
        //kyotu.rrCountLock = H_99_63_SaveData.GetBool("rrCountLock", true);
        kyotu.ReadMePanelCount = PlayerPrefs.GetInt("ReadMePanelCount", 0);

        //tup表示させるか否かのboolロード
        ///mokujiのtup
        kyotu.TupBoolMeidai1_1 = H_99_63_SaveData.GetBool("TupBoolMeidai1_1", true);//一番最初常にtrue
        kyotu.TupBoolMeidai1_2 = H_99_63_SaveData.GetBool("TupBoolMeidai1_2", true);
        kyotu.TupBoolMeidai1_3 = H_99_63_SaveData.GetBool("TupBoolMeidai1_3", true);
        kyotu.TupBoolMeidai1_4 = H_99_63_SaveData.GetBool("TupBoolMeidai1_4", true);
        kyotu.TupBoolMeidai1_5 = H_99_63_SaveData.GetBool("TupBoolMeidai1_5", true);
        kyotu.TupBoolMeidai1_6 = H_99_63_SaveData.GetBool("TupBoolMeidai1_6", true);
        ///フラグのtup
        kyotu.TupKouri1 = H_99_63_SaveData.GetBool("TupKouri1", false);
        kyotu.TupKouri3 = H_99_63_SaveData.GetBool("TupKouri3", false);
        kyotu.TupKouri4 = H_99_63_SaveData.GetBool("TupKouri4", false);
        kyotu.TupKouri5 = H_99_63_SaveData.GetBool("TupKouri5", false);

        kyotu.TupKoujun1 = H_99_63_SaveData.GetBool("TupKoujun1", false);
        kyotu.TupKoujun2 = H_99_63_SaveData.GetBool("TupKoujun2", false);
        kyotu.TupKoujun3 = H_99_63_SaveData.GetBool("TupKoujun3", false);

        kyotu.TupTeigi1 = H_99_63_SaveData.GetBool("TupTeigi1", true);
        kyotu.TupTeigi15 = H_99_63_SaveData.GetBool("TupTeigi15", true);//一番最初常にtrue

        //フラグ一番最後のパネル証明のtupを表示か非表示か
        kyotu.tupBoolShomeiMeidai1_1 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_1",false);
        kyotu.tupBoolShomeiMeidai1_2 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_2",false);
        kyotu.tupBoolShomeiMeidai1_3 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_3", false);
        kyotu.tupBoolShomeiMeidai1_4 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_4", false);
        kyotu.tupBoolShomeiMeidai1_5 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_5", false);
        kyotu.tupBoolShomeiMeidai1_6 = H_99_63_SaveData.GetBool("tupBoolShomeiMeidai1_6", false);

        //内容を表示させるか？？？を決めるboolのロード
        ///目次パネルの表示　内容表示か？？？かのboolのロード
        kyotu.BoolMeidai1_1 = H_99_63_SaveData.GetBool("BoolMeidai1_1", true);//一番最初常にtrue
        kyotu.BoolMeidai1_2 = H_99_63_SaveData.GetBool("BoolMeidai1_2", false);
        kyotu.BoolMeidai1_3 = H_99_63_SaveData.GetBool("BoolMeidai1_3", false);
        kyotu.BoolMeidai1_4 = H_99_63_SaveData.GetBool("BoolMeidai1_4", false);
        kyotu.BoolMeidai1_5 = H_99_63_SaveData.GetBool("BoolMeidai1_5", false);
        kyotu.BoolMeidai1_6 = H_99_63_SaveData.GetBool("BoolMeidai1_6", false);

        ///フラグ図の一番下　meidaiの内容false？？？true内容表示 フラグ↓ロード
        kyotu.BoolShomeiMeidai1_1 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_1", false);
        kyotu.BoolShomeiMeidai1_2 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_2", false);
        kyotu.BoolShomeiMeidai1_3 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_3", false);
        kyotu.BoolShomeiMeidai1_4 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_4", false);
        kyotu.BoolShomeiMeidai1_5 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_5", false);
        kyotu.BoolShomeiMeidai1_6 = H_99_63_SaveData.GetBool("BoolShomeiMeidai1_6", false);

        ///フラグパネルの???か内容か決めるboolのロード
        kyotu.BoolKouri1 = H_99_63_SaveData.GetBool("BoolKouri1", false);
        kyotu.BoolKouri3 = H_99_63_SaveData.GetBool("BoolKouri3", false);
        kyotu.BoolKouri4 = H_99_63_SaveData.GetBool("BoolKouri4", false);
        kyotu.BoolKouri5 = H_99_63_SaveData.GetBool("BoolKouri5", false);

        kyotu.BoolKoujun1 = H_99_63_SaveData.GetBool("BoolKoujun1", false);
        kyotu.BoolKoujun2 = H_99_63_SaveData.GetBool("BoolKoujun2", false);
        kyotu.BoolKoujun3 = H_99_63_SaveData.GetBool("BoolKoujun3", false);

        kyotu.BoolTeigi1 = H_99_63_SaveData.GetBool("BoolTeigi1", false);
        kyotu.BoolTeigi15 = H_99_63_SaveData.GetBool("BoolTeigi15", true);//一番最初　常にtrue
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
        //前にgameをやめた場所の記憶をロード

        PlayerPrefs.SetInt("rrCount", kyotu.rrCount);
        PlayerPrefs.SetInt("mainCameraPosi",kyotu.mainCameraPosi);
        //Debug.Log("cameraposi::"+PlayerPrefs.GetInt("mainCameraPosi", 0));
        //変数名が分かりにくいが、readmepanel表示にするか決めるbool変数
        //H_99_63_SaveData.SetBool("rrCountLock", kyotu.rrCountLock);
        PlayerPrefs.SetInt("ReadMePanelCount", kyotu.ReadMePanelCount);

        PlayerPrefs.SetInt("mojiSwitch", kyotu.mojiSwitch);
        PlayerPrefs.SetInt("MCount", kyotu.MCount);
        PlayerPrefs.SetInt("meidaiHensu", kyotu.meidaiHensu);

        //tup表示させるか否かのboolロード
        ///mokujiのtup
        H_99_63_SaveData.SetBool("TupBoolMeidai1_1", kyotu.TupBoolMeidai1_1);//一番最初常にtrue
        H_99_63_SaveData.SetBool("TupBoolMeidai1_2", kyotu.TupBoolMeidai1_2);
        H_99_63_SaveData.SetBool("TupBoolMeidai1_3", kyotu.TupBoolMeidai1_3);
        H_99_63_SaveData.SetBool("TupBoolMeidai1_4", kyotu.TupBoolMeidai1_4);
        H_99_63_SaveData.SetBool("TupBoolMeidai1_5", kyotu.TupBoolMeidai1_5);
        H_99_63_SaveData.SetBool("TupBoolMeidai1_6", kyotu.TupBoolMeidai1_6);

        ///フラグのtup
        H_99_63_SaveData.SetBool("TupKouri1", kyotu.TupKouri1);
        H_99_63_SaveData.SetBool("TupKouri3", kyotu.TupKouri3);
        H_99_63_SaveData.SetBool("TupKouri4", kyotu.TupKouri4);
        H_99_63_SaveData.SetBool("TupKouri5", kyotu.TupKouri5);

        H_99_63_SaveData.SetBool("TupKoujun1", kyotu.TupKoujun1);
        H_99_63_SaveData.SetBool("TupKoujun2", kyotu.TupKoujun2);
        H_99_63_SaveData.SetBool("TupKoujun3", kyotu.TupKoujun3);

        H_99_63_SaveData.SetBool("TupTeigi1", kyotu.TupTeigi1);
        H_99_63_SaveData.SetBool("TupTeigi15", kyotu.TupTeigi15);//一番最初常にtrue
        
        //フラグ一番最後のパネル証明のtupを表示か非表示か
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_1", kyotu.tupBoolShomeiMeidai1_1);
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_2", kyotu.tupBoolShomeiMeidai1_2);
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_3", kyotu.tupBoolShomeiMeidai1_3);
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_4", kyotu.tupBoolShomeiMeidai1_4);
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_5", kyotu.tupBoolShomeiMeidai1_5);
        H_99_63_SaveData.SetBool("tupBoolShomeiMeidai1_6", kyotu.tupBoolShomeiMeidai1_6);

        //内容を表示させるか？？？を決めるboolのロード
        ///目次パネルの表示　内容表示か？？？かのboolのsave
        //kyotu.meidai1～6までをsave
        H_99_63_SaveData.SetBool("BoolMeidai1_1", kyotu.BoolMeidai1_1);
        H_99_63_SaveData.SetBool("BoolMeidai1_2", kyotu.BoolMeidai1_2);
        H_99_63_SaveData.SetBool("BoolMeidai1_3", kyotu.BoolMeidai1_3);
        H_99_63_SaveData.SetBool("BoolMeidai1_4", kyotu.BoolMeidai1_4);
        H_99_63_SaveData.SetBool("BoolMeidai1_5", kyotu.BoolMeidai1_5);
        H_99_63_SaveData.SetBool("BoolMeidai1_6", kyotu.BoolMeidai1_6);

        ///フラグ図の一番下　meidaiの内容false？？？true内容表示 フラグ↓ロード
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_1", kyotu.BoolShomeiMeidai1_1);
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_2", kyotu.BoolShomeiMeidai1_2);
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_3", kyotu.BoolShomeiMeidai1_3);
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_4", kyotu.BoolShomeiMeidai1_4);
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_5", kyotu.BoolShomeiMeidai1_5);
        H_99_63_SaveData.SetBool("BoolShomeiMeidai1_6", kyotu.BoolShomeiMeidai1_6);

        ///フラグパネルの???か内容か決めるboolのロード
        H_99_63_SaveData.SetBool("BoolKouri1", kyotu.BoolKouri1);
        H_99_63_SaveData.SetBool("BoolKouri3", kyotu.BoolKouri3);
        H_99_63_SaveData.SetBool("BoolKouri4", kyotu.BoolKouri4);
        H_99_63_SaveData.SetBool("BoolKouri5", kyotu.BoolKouri5);

        H_99_63_SaveData.SetBool("BoolKoujun1", kyotu.BoolKoujun1);
        H_99_63_SaveData.SetBool("BoolKoujun2", kyotu.BoolKoujun2);
        H_99_63_SaveData.SetBool("BoolKoujun3", kyotu.BoolKoujun3);

        H_99_63_SaveData.SetBool("BoolTeigi1", kyotu.BoolTeigi1);
        H_99_63_SaveData.SetBool("BoolTeigi15", kyotu.BoolTeigi15);//一番最初　常にtrue

        

        //H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    //private void OnApplicationQuit()
    //{
    //    PlayerPrefs.SetInt("rrCount",kyotu.rrCount);
    //    //H_99_63_SaveData.SetBool("saveBool", SaveBool);


    //}
}
