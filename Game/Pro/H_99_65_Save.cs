using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_65_Save : MonoBehaviour
{
    int save = 0;

    public bool SaveBool = false;
    void Start()
    {
        save = PlayerPrefs.GetInt("save", 0);
        SaveBool = H_99_63_SaveData.GetBool("saveBool", false);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SaveBool);

        if (Input.GetMouseButtonDown(0)) 
        {
            save++;
            SaveBool = true;
            //Debug.Log(SaveBool);


        }
        else if (Input.GetMouseButtonDown(1)) 
        {
            SaveBool = false;
            //Debug.Log(SaveBool);
        }

    }
    void OnDestroy()
    {
        // スコアを保存
        //PlayerPrefs.SetInt("SCORE", SaveTest);
        //PlayerPrefs.Save();

        H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("save",save);
        H_99_63_SaveData.SetBool("saveBool", SaveBool);


    }
}
