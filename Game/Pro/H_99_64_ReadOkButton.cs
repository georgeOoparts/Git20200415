using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_64_ReadOkButton : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public GameObject ReadOk;

  
    void Start()
    {
        Debug.Log("H_99_64_ReadOkButton::");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickReadOK() 
    {
        Debug.Log("H_99_64_ReadOkButton>onclickok::OKKKKKKOKKKK");
        kyotu.TupBoolMeidai1_1 = true;
        kyotu.TupBoolMeidai1_2 = false;

        kyotu.TupTeigi15 = false;

        kyotu.TupKoujun1 = true;

        //k7オブジェクトを直接onoff
        //k7　GameObject.SetActive(true);

        ReadOk.SetActive(false);
    }
    public void onClickReadNo() 
    {
        Debug.Log("H_99_64_ReadOkButton>onclickno::NOOOONOOO");
    }
}
