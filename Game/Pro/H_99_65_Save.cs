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
        PlayerPrefs.SetInt("rrCount", kyotu.rrCount);
        //PlayerPrefs.Save();

        //H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("rrCount",kyotu.rrCount);
        //H_99_63_SaveData.SetBool("saveBool", SaveBool);


    }
}
