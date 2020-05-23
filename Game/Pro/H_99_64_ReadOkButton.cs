using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_64_ReadOkButton : MonoBehaviour
{
    public H_99_01_kyoutuHensu kyotu;

    public GameObject ReadOk;

  
    void Start()
    {
        //Debug.Log("H_99_64_ReadOkButton::");    
    }
    
    void Update()
    {
        
    }
    //rrを最後まで読んだとき出てくるパネルREADOKにYESと答えた時の処理

    public void onClickReadOK() 
    {
        //rrcount最後まで読み込み。readok？にyesと返した時の処理
        //Debug.Log("H_99_64_ReadOkButton>onclickok::OKKKKKKOKKKK::"+ kyotu.BoolrrReadTeigi15);
        //tup表示があるものだけ処理。tupboolがfalseのものはただメインカメラの位置を1にして　ｒｒcount=0にする
        if (kyotu.TupKouri1 == true && kyotu.mojiSwitch == 0 && kyotu.MCount == 0)
        {
            //Debug.Log("kouriIN");
            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);
            //readok　buttonを消す
            ReadOk.SetActive(false);
            //目次　タップ表示　on　off
            kyotu.TupBoolMeidai1_1 = true;

            //フラグパネルのtup表示　on　off
            kyotu.TupKouri1 = false;
            kyotu.tupBoolShomeiMeidai1_1 = true;
            //次に？？？から表示があれば
            kyotu.BoolShomeiMeidai1_1 = true;

            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;


            //Debug.Log("kouriOut");

        }
        else if (kyotu.TupKouri3 == true && kyotu.mojiSwitch == 0 && kyotu.MCount == 1)
        {
            //Debug.Log("kouriIN");
            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);
            //readok　buttonを消す
            ReadOk.SetActive(false);
            //目次　タップ表示　on　off
            //kyotu.TupBoolMeidai1_1 = true;

            //フラグパネルのtup表示　on　off
            kyotu.TupKouri3 = false;
            kyotu.tupBoolShomeiMeidai1_2 = true;
            //次に？？？から表示があれば
            kyotu.BoolShomeiMeidai1_2 = true;

            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;


            //Debug.Log("kouriOut");

        }
        else if (kyotu.TupTeigi15==true&&kyotu.mojiSwitch==2&&kyotu.MCount==1) 
        {
            //目次　タップ表示　on　off
            kyotu.TupBoolMeidai1_1 = true;
            kyotu.TupBoolMeidai1_2 = false;

            //フラグパネルのtup表示　on　off
            kyotu.TupTeigi15 = false;
            kyotu.TupKoujun1 = true;
            kyotu.BoolKoujun1 = true;

            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;

            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);
            //readok　buttonを消す
            ReadOk.SetActive(false);
        }
        else if (kyotu.TupKoujun1 == true && kyotu.mojiSwitch == 1 && kyotu.MCount == 0)
        {
            //Debug.Log("seikou;;BoolKoujun1");
            //kyotu.TupBoolMeidai1_1 = true;
            //kyotu.TupBoolMeidai1_2 = false;

            //kyotu.TupTeigi15 = false;

            //kyotu.TupKoujun1 = true;

            //現在のtup消し次のtup開放
            kyotu.TupKoujun1 = false;
            kyotu.TupKoujun3 = true;

            //次の表示開放　一回開放したらfalseには戻さない
            kyotu.BoolKoujun3 = true;


            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;
            //kyotu.BoolKoujun1 = true;

            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);

            ReadOk.SetActive(false);
        }
        else if (kyotu.TupKoujun3 == true && kyotu.mojiSwitch == 1 && kyotu.MCount == 2)
        {
            
            //現在のtup消し次のtup開放
            kyotu.TupKoujun3 = false;
            kyotu.TupKouri1 = true;

            //次の表示開放　一回開放したらfalseには戻さない
            kyotu.BoolKouri1 = true;


            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;

            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);

            ReadOk.SetActive(false);
        }
        else if (kyotu.tupBoolShomeiMeidai1_1 == true && kyotu.mojiSwitch == 3 && kyotu.MCount == 0) 
        {
            //Debug.Log("shoumeiIN::rrcout;:"+kyotu.rrCount);

            //m1_2が開く
            //目次 ？？？から表示があれば
            kyotu.BoolMeidai1_2 = true;

            //目次　タップ表示　on　off
            kyotu.TupBoolMeidai1_1 = false;
            kyotu.TupBoolMeidai1_2 = true;


            //フラグパネルのtup表示　on　off
            kyotu.tupBoolShomeiMeidai1_1 = false;
            kyotu.TupKoujun2 = true;

            //次に？？？から表示があれば
            kyotu.BoolKoujun2 = true;

            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 0;
            kyotu.rrCount = 0;
            
            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);
            //readok　buttonを消す
            ReadOk.SetActive(false);
            //Debug.Log("shoumeiOut::rrcout;:"+kyotu.rrCount);

        }
        else if (kyotu.TupKoujun2 == true && kyotu.mojiSwitch == 1 && kyotu.MCount == 1)
        {

            //現在のtup消し次のtup開放
            kyotu.TupKoujun2 = false;
            kyotu.TupKouri3 = true;

            //次の表示開放　一回開放したらfalseには戻さない
            kyotu.BoolKouri3 = true;


            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;

            //k7オブジェクトを直接onoff
            //k7　GameObject.SetActive(true);

            ReadOk.SetActive(false);
        }
        else 
        {
            //最後までrrをやり終えたら、フラグにカメラを戻す。次の???を開放
            kyotu.mainCameraPosi = 1;
            kyotu.rrCount = 0;
            ReadOk.SetActive(false);

        }
        

    }
    //rrを最後まで読んだとき出てくるパネルREADOKにNOと答えた時の処理
    public void onClickReadNo() 
    {
        //Debug.Log("H_99_64_ReadOkButton>onclickno::NOOOONOOO");
        kyotu.rrCount = 0;
        ReadOk.SetActive(false);
    }
}
