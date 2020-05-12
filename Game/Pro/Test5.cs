using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test5 : MonoBehaviour
{
    // 現在使われていない
    // int boolのsave　
    //　boolはunityでsave設定されていなく、転がっていたプログラムを使っているためデータの削除自体ができないが
    //　実装上は問題なし。
    
    
    //public int SaveTest = 0;

    public bool SaveBool = false;
    //const string DataKey = "saveDataKey";
    void Start()
    {
        // スコアのロード
        //SaveTest = PlayerPrefs.GetInt("SCORE", 0);

        //Debug.Log(H_99_63_SaveData.GetBool(DataKey, false)); // false
        //H_99_63_SaveData.SetBool(DataKey, true);
        SaveBool = H_99_63_SaveData.GetBool("saveBool", false);
    }

    // 削除時の処理
    void OnDestroy()
    {
        // スコアを保存
        //PlayerPrefs.SetInt("SCORE", SaveTest);
        //PlayerPrefs.Save();

        H_99_63_SaveData.SetBool("saveBool", SaveBool);
        //PlayerPrefs.DeleteAll();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            //SaveTest++;
            SaveBool = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            //PlayerPrefs.DeleteAll();
            //SaveTest = 0;
            SaveBool = false;
        }

        Debug.Log("Test5>Update::SaveBool::"+ SaveBool);
    }
}
