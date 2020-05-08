using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class H_99_61_MokujiQuetion : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public GameObject TextMokuji1_2;
    public GameObject TextMokuji1_3;
    public GameObject TextMokuji1_4;
    public GameObject TextMokuji1_5;
    public GameObject TextMokuji1_6;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(kyotu.BoolMeidai1_2 == true)
        {
            Debug.Log("true");
            TextMokuji1_2.GetComponent<Text>().text = "命題Ⅰ-2\n与えられた直線と同じ長さの直線を与えられた点から作図すること";
            TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
        }
        else
        {
            Debug.Log("false");

            TextMokuji1_2.GetComponent<Text>().text = "???";
            TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        }



        //TextMokuji1_2.GetComponent<Text>().text = "???";
        //TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

        //Debug.Log("canvas>mokujipanel>movemokujipanel>H_99_61_MokujiQuetion::boolmeidai::"+kyotu.BoolMeidai1_2);
    }
}
