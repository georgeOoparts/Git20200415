using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_66_LastButtonScript : MonoBehaviour
{
    //canvas>mokujipanel＞lastbuttonを制御するプログラム
    //canvas>mokujipanel＞lastbutotonにアタッチ
    //2020/05/25　bool　kyotu.LastPanelHyoujiでtrue表示、falseで非表示　実装
    //2020/05/25　int　kyotu.LastPanelCountでtext内容を変更する　実装
    //2020/05/25　H_99_65_Saveでbool　kyotu.LastPanelHyouji、int　kyotu.LastPanelCountのsave実装　
    public H_99_01_kyoutuHensu kyotu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kyotu.LastPanelHyouji==true) 
        {
            this.gameObject.GetComponent<Image>().enabled = true;

            this.gameObject.transform.GetChild(0).GetComponent<Text>().enabled = true;
        }
        else 
        {
            this.gameObject.GetComponent<Image>().enabled = false;

            this.gameObject.transform.GetChild(0).GetComponent<Text>().enabled = false;
        }

        //kyotu.maincameraposi=0 kyotu.LastPanelHyouji=trueでクリックするとkyotu.LastPanelCountが進む
        if (Input.GetMouseButtonDown(0)&& kyotu.LastPanelHyouji==true&&kyotu.mainCameraPosi==0) 
        {
            kyotu.LastPanelCount++;
        }
        //kyotu.LastPanelCountが進むにつれてtextの内容が変わる
        //count4以上でlastbuttonパネル自体が消える。
        if (kyotu.LastPanelCount == 0)
        {
            this.gameObject.transform.GetChild(0).GetComponent<Text>().text = "最後までクリックして"+"\n"+
            "くれてありがとう";
        }
        else if (kyotu.LastPanelCount == 1)
        {
            this.gameObject.transform.GetChild(0).GetComponent<Text>().text = "このままいけば円の" + "\n" +
            "面積や体積も簡単に" + "\n" +
            "求められますが....";
        }
        else if (kyotu.LastPanelCount == 2)
        {
            this.gameObject.transform.GetChild(0).GetComponent<Text>().text = "予算がないのでまずは" + "\n" +
            "ここまで";
        }
        else if (kyotu.LastPanelCount == 3)
        {
            this.gameObject.transform.GetChild(0).GetComponent<Text>().text = "数学の全ての分野が" + "\n" +
            "GAME化されますように";
        }
        else if (kyotu.LastPanelCount == 4)
        {
            this.gameObject.transform.GetChild(0).GetComponent<Text>().text = "それではみなさん" + "\n" +
            "さよならDEATH";
        }
        else 
        {
            kyotu.LastPanelHyouji = false;
            kyotu.LastPanelCount = 0;
        }

        Debug.Log("okkk" + kyotu.LastPanelHyouji + kyotu.LastPanelCount);

    }
}
