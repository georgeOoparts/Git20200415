using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_65_Save : MonoBehaviour
{
    public H_99_01_kyoutuHensu　kyotu;

    int save = 0;



    public bool SaveBool = false;
    void Start()
    {
        kyotu.rrCount = PlayerPrefs.GetInt("rrCount", 0);
        //SaveBool = H_99_63_SaveData.GetBool("saveBool", false);
        //kyotu.rrCountLock = H_99_63_SaveData.GetBool("rrCountLock", true);
        kyotu.ReadMePanelCount= PlayerPrefs.GetInt("ReadMePanelCount", 0);

        kyotu.TupBoolMeidai1_1 = H_99_63_SaveData.GetBool("BoolMeidai1_1", true);
        kyotu.TupTeigi15 = H_99_63_SaveData.GetBool("TupTeigi15", true);
        kyotu.TupKoujun1 = H_99_63_SaveData.GetBool("TupKoujun1", true);


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("H_99_65_Save>Update::" + kyotu.rrCount) ;

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
        Debug.Log("cameraposiFirst::"+kyotu.mainCameraPosi);
        PlayerPrefs.SetInt("rrCount", kyotu.rrCount);
        PlayerPrefs.SetInt("mainCameraPosi",kyotu.mainCameraPosi);
        Debug.Log("cameraposi::"+PlayerPrefs.GetInt("mainCameraPosi", 0));
        //変数名が分かりにくいが、readmepanel表示にするか決めるbool変数
        //H_99_63_SaveData.SetBool("rrCountLock", kyotu.rrCountLock);
        PlayerPrefs.SetInt("ReadMePanelCount", kyotu.ReadMePanelCount);
        
        H_99_63_SaveData.SetBool("TupBoolMeidai1_1", kyotu.TupBoolMeidai1_1);
        H_99_63_SaveData.SetBool("TupTeigi15", kyotu.TupTeigi15);
        H_99_63_SaveData.SetBool("TupKoujun1", kyotu.TupKoujun1);

        
        //H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    //private void OnApplicationQuit()
    //{
    //    PlayerPrefs.SetInt("rrCount",kyotu.rrCount);
    //    //H_99_63_SaveData.SetBool("saveBool", SaveBool);


    //}
}
