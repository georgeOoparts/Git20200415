using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_57_TateFlagFlickSwipe : MonoBehaviour
{
    //縦移動のみスワイプ--------------------
    //縦移動のみフリック
    //tupしていた時間を得るプログラム
    //tupしていた距離を得るプログラム
    //メインカメラにアタッチ
    //フリック、スワイプとも＞パブリックでMOVEパネル（toumeiPanel）をインスぺで当てはめる
    //フリック、スワイプともにmovepanelが上下に動く

    //メインカメラが目次にある時のみ、目次透明パネルが上下移動するようにする。

    //メインカメラの位置を得るために、インスぺでメインカメラを当てはめる
    public GameObject mainCamera;
    Transform trMainCamera;

    //パブリックでMOVEパネルを当てはめる
    //この透明のパネルの子にmojipanelが並ぶ。
    //親のmovepanelが動かすことで、子のmojipanelが上下移動する
    public GameObject toumeiPanel;
    //toumeiPanelのRectTransformが入る変数
    RectTransform rtToumeiPanel;

    //縦移動のみスワイプ--------------------

    //横移動に使うT0015M_DmoveYokoPanelSwipe、
    //を判定するyokoMoveHantei()はT0016M_DtateFlickSwipeMeidaiから借りる



    //public float yokoMove = 0;
    void Start()
    {
        //toumeiPanelのRectTransformが入る変数当てはめる
        rtToumeiPanel = toumeiPanel.GetComponent<RectTransform>();

        //maincameraのtransformが入る変数当てはめる
        trMainCamera = mainCamera.GetComponent<Transform>();
    }
    ////k6_1:ストップウォッチ関数を使う時のおまじない。
    //private System.Diagnostics.Stopwatch stopwatch
    //    = new System.Diagnostics.Stopwatch();
    ////k6_1_1:何秒たったかを変数elapseに入れる：update内に入れる-------
    //////?
    //private float elapse;
    void Update()
    {
        //Debug.Log(trMainCamera.position);
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。
        //>tupTimeHanteiに使う。>swipe()に使う
        //elapse = (float)stopwatch.Elapsed.TotalSeconds;

        

        //フリックをするメソッド
        flick();
        //Debug.Log("575757575775;;;;;");
    }
    //flick------カメラは動かさずパネルを動かす--------------------------------------------------------------------
    //フリックをするメソッド

    Vector3 tupDown = new Vector3(0, 0, 0);
    Vector3 diff = new Vector3(0, 0, 0);

    void flick()
    {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        if (Input.GetMouseButtonDown(0))
        {
            tupDown = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            if (tupDown != Input.mousePosition)
            {
                Vector3 diff = Input.mousePosition - tupDown;
                //横移動判定がなければかつメインカメラのx軸が1ならば
                if (/*yokoMove == 0 && */trMainCamera.position.x == 5)

                    rtToumeiPanel.anchoredPosition
                    = new Vector2(0, rtToumeiPanel.anchoredPosition.y + diff.y);

            }
            tupDown = Input.mousePosition;
        }
    }
    //flick-----end---------------------------------------------------------------------
}
