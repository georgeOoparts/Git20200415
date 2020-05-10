using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_62_FlagQuetion : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public GameObject BoolTeigi15;
    public GameObject BoolKoujun1;
    public GameObject BoolKoujun3;
    public GameObject BoolKouri1;
    public GameObject BoolShoumei1;

    void Start()
    {
        //Debug.Log("rerer"+ kyotu.BoolTeigi15);
    }

    // Update is called once per frame
    void Update()
    {
        if (kyotu.BoolKoujun1 == true)
        {
            //Debug.Log("true");
            BoolKoujun1.GetComponent<Text>().text = "公準P-1\n任意の点から任意の点へ直線を\n引くことができる";
            BoolKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else 
        {
            BoolKoujun1.GetComponent<Text>().text = "???";
            BoolKoujun1.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }
        //Debug.Log("H_99_01_kyoutuHensu>update::rrCount::" + kyotu.rrCount);
    }
}
