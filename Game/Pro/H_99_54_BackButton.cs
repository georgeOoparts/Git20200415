using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class H_99_54_BackButton : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public T0020M_mojiHonban moji;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("wrererer");
    }

    public void onClick() 
    {
        Debug.Log("54backbutton>onClick:kyotu.rrCount:" + kyotu.rrCount);
    }
}
