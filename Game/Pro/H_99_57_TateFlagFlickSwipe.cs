using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_57_TateFlagFlickSwipe : MonoBehaviour
{

    public H_99_01_kyoutuHensu kyotu;

    //flagの縦スワイプをするプログラム
    //canvas>flagpanel>moveflagpanelにアタッチ
    //縦移動のみスワイプ--------------------
    //縦移動のみフリック
    //tupしていた時間を得るプログラム
    //tupしていた距離を得るプログラム
    //メインカメラにアタッチ
    //フリック、スワイプとも＞パブリックでMOVEパネル（moveflagPanel）をインスぺで当てはめる
    //フリック、スワイプともにmovepanelが上下に動く

    //メインカメラが目次にある時のみ、目次透明パネルが上下移動するようにする。

    //メインカメラの位置を得るために、インスぺでメインカメラを当てはめる
    public GameObject mainCamera;
    Transform trMainCamera;

    //パブリックでMOVEパネルを当てはめる
    //この透明のパネルの子にmojipanelが並ぶ。
    //親のmovepanelが動かすことで、子のmojipanelが上下移動する
    public GameObject moveFlagPanel;
    //moveFlagPanelのRectTransformが入る変数
    RectTransform rtmoveFlagPanel;

    //縦移動のみスワイプ--------------------

    //横移動に使うT0015M_DmoveYokoPanelSwipe、
    //を判定するyokoMoveHantei()はT0016M_DtateFlickSwipeMeidaiから借りる



    //public float yokoMove = 0;
    void Start()
    {
        //toumeiPanelのRectTransformが入る変数当てはめる
        rtmoveFlagPanel = moveFlagPanel.GetComponent<RectTransform>();

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
        elapse = (float)stopwatch.Elapsed.TotalSeconds;


        //フリックをするメソッド
        flick();
        //スワイプをするメソッド
        //スワイプしている最中どこかをtupするとスワイプを止める。
        //swipe();

        //tupTimeHantei();
        //Debug.Log("H_99_57_TateFlagFlickSwipe>update::kyotu.meidaihensu::"+kyotu.meidaiHensu);

        //（フリック、スワイプで）目次がある値以上の場所へ行かない処理（movemokujipanelが）
        // 全体を動かすmovemokujipanelオブジェが下へ行きすぎないように制御
        if (kyotu.meidaiHensu==0) 
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y >= 20)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 20);
            }
        }
        else if (kyotu.meidaiHensu == 1)
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y >= 325)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 325);
            }
        }
        else if (kyotu.meidaiHensu == 2)
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y >= 60)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 60);
            }
        }
        else if (kyotu.meidaiHensu == 3)
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y > 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
        }
        else if (kyotu.meidaiHensu == 4)
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y >= 265)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 265);
            }
        }
        else if (kyotu.meidaiHensu == 5)
        {
            if (rtmoveFlagPanel.anchoredPosition.y <= 0)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 0);
            }
            ///全体を動かすmovemokujipanelより上へ行かないように制御
            else if (rtmoveFlagPanel.anchoredPosition.y >= 95)
            {
                rtmoveFlagPanel.anchoredPosition = new Vector2(0, 95);
            }
        }
    }
    //tupTimeHantei-------------------------------------------------------------------------------
    //tupしてから指を離した時、その時間が0.35秒以内だった瞬間だけ
    //変数timeHanteiが1、その他はtimeHanteiが0になるメソッド
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    //tupしてから指を放すまで何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;
    //tupしてから指を離した時、その時間が0.35秒以内だった瞬間だけ
    //変数timeHanteiが1、その他はtimeHanteiが0
    int timeHantei = 0;

    void tupTimeHantei()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timeHantei = 0;
            stopwatch.Start();
            //Debug.Log("kokokuru?::"+elapse);

        }
        if (Input.GetMouseButtonUp(0))
        {
            if (elapse <= 0.35)
            {
                timeHantei = 1;
                //Debug.Log(timeHantei);
            }
            else
            {
                timeHantei = 0;
                //Debug.Log(timeHantei);

            }
            //Debug.Log("kokokuru?::"+elapse);

            stopwatch.Reset();
            stopwatch.Stop();
            //Debug.Log("kokokuru?::"+elapse);
        }
        else//tup　upしてない時はtimeHantei常に0 
        {
            timeHantei = 0;
        }
    }
    //tupTimeHantei---end----------------------------------------------------------------------------

    //yokoMoveHantei-----------------------------------------------------------
    //void flick()の　中で使う。yokomoveが0の時のみ、上下フリック、スワイプするようにする
    public float yokoMove = 0;
    Vector3 yokopMoveHanteiFirstPoint = new Vector3(0, 0, 0);
    Vector3 yokopMoveHanteiSa = new Vector3(0, 0, 0);
    void yokoMoveHantei()
    {
        if (Input.GetMouseButtonDown(0))
        {
            yokoMove = 0;
            yokopMoveHanteiFirstPoint = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            yokopMoveHanteiSa = Input.mousePosition - yokopMoveHanteiFirstPoint;

            if (yokopMoveHanteiSa.x == 0)
            {
                yokoMove = 0;
            }
            else if (yokopMoveHanteiSa.y == 0)
            {
                if (yokopMoveHanteiSa.x > 0)
                {
                    yokoMove = -1;
                }
                else
                {
                    yokoMove = 1;
                }

            }
            else
            {
                if (-0.3 <= yokopMoveHanteiSa.y / yokopMoveHanteiSa.x
                    && yokopMoveHanteiSa.y / yokopMoveHanteiSa.x <= 0.3)
                {
                    if (yokopMoveHanteiSa.x > 0)
                    {
                        yokoMove = -1;
                    }
                    else
                    {
                        yokoMove = 1;
                    }
                    //Debug.Log(yokoMove);
                }
            }
        }
    }

    //yokoMoveHantei-----------end---------------------------------------------
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
                if (yokoMove == 0 && trMainCamera.position.x == 5)

                    rtmoveFlagPanel.anchoredPosition
                    = new Vector2(0, rtmoveFlagPanel.anchoredPosition.y + diff.y);

            }
            tupDown = Input.mousePosition;
        }
    }
    //flick-----end---------------------------------------------------------------------
}
