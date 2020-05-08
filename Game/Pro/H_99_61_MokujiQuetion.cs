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
        TextMokuji1_2.GetComponent<Text>().text = "???";
        TextMokuji1_2.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

        Debug.Log("canvas>mokujipanel>movemokujipanel>H_99_61_MokujiQuetion::boolmeidai::"+kyotu.BoolMeidai1_6);
    }
}
