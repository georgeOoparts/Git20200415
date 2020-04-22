using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0019M_moveCameraNumber : MonoBehaviour
{
    //maincameraにこのプログラムはアタッチされている。
    //共通変数のカメラポジションの数値が変化すると、メインカメラの位置が変わる
    //共通変数カメラポジション0＞メインカメラのx座標　0
    //共通変数カメラポジション1＞メインカメラのx座標　5
    //共通変数カメラポジション2＞メインカメラのx座標　10
    Transform cameraMove;

    public H_99_01_kyoutuHensu kyotu;

    //↓メインカメラにアタッチされているスクリプトの変数を使うのでインスぺでメインカメラ指定
    public T0016M_DtateFlickSwipeMeidai yokoMove;
    void Start()
    {
        cameraMove = this.gameObject.GetComponent<Transform>();
        //Debug.Log("ddddesu::"+ T0002M_kyotuHensu.cameraPosiNumber);    
    }

    void Update()
    {
        if (yokoMove.yokoMove==0) 
        {
            //使いまわす変数kyotu.mainCameraPosiを使う
            if (kyotu.mainCameraPosi == 0)
            {
                cameraMove.position = new Vector3(0, cameraMove.position.y, cameraMove.position.z);
            }
            else if (kyotu.mainCameraPosi == 1)
            {
                cameraMove.position = new Vector3(5, cameraMove.position.y, cameraMove.position.z);
            }
            else if (kyotu.mainCameraPosi == 2)
            {
                cameraMove.position = new Vector3(10, cameraMove.position.y, cameraMove.position.z);
            }
        }
        //Debug.Log(this.gameObject);   
    }
}
