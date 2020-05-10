using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    public int SaveTest = 0;
    void Start()
    {
        // スコアのロード
        SaveTest = PlayerPrefs.GetInt("SCORE", 0);
    }

    // 削除時の処理
    void OnDestroy()
    {
        // スコアを保存
        PlayerPrefs.SetInt("SCORE", SaveTest);
        PlayerPrefs.Save();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            SaveTest++;
        }
        if (Input.GetMouseButtonDown(1))
        {
            PlayerPrefs.DeleteAll();
            SaveTest = 0;
        }

        Debug.Log("Test5>Update::SaveTest::"+ SaveTest);
    }
}
