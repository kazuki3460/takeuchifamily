using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //追加（長田）
using System;　//追加（長田）
using System.IO;　//追加（長田）

public class Test : MonoBehaviour
{
    Entity_Sheet1 es;


    public static string SampleStart; //入力するやつ　staticをつけた（長田）
    public static string SampleGoal;　//staticをつけた（長田）

    int start;
    int goal;

    public static int ekisuu; //合計値　staticをつけた(長田)

    public Text num; //path用
    public Text st;
    public Text go;

    public InputField inputfield1;　//ゲームオブジェクトに結びつけるために追加（長田）
    public InputField inputfield2;　//同上(長田)

   

    // Start is called before the first frame update
    void Start()
    { 
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputText() //inputfieldで入力した文字列をSampleStart・SampleGoalに代入してる（長田）
    {
        SampleStart = inputfield1.text;
        SampleGoal = inputfield2.text;
    }

    public void PushStartButton()
    {
        es = Resources.Load("takeuchi") as Entity_Sheet1; //エクセル呼び出し  
        int i;
        for (i = 0; i < 20; i++)
        {//長さはlength取得に変更すべき
            if (SampleStart.Equals(es.sheets[0].list[i].name))
            {
                Debug.Log("発:" + es.sheets[0].list[i].name);//発：ありましたのデバッグ表示
                start = i;//発の駅の番号を保管しておく
            }
            if (SampleGoal.Equals(es.sheets[0].list[i].name))
            {
                Debug.Log("着:" + es.sheets[0].list[i].name);//着：ありましたのデバッグ表示
                goal = i;//着の駅の番号を保管しておく
            }
        }
        if (goal > start)
        {
            ekisuu = goal - start; //駅数を算出
        }
        else
        {
            ekisuu = start - goal; //駅数を算出
        }
       /* num.text = ekisuu.ToString(); int型（数字のみ）からstring型（文字）へ*/ //バグが出るので隠してる（長田）
        /*st.text = es.sheets[0].list[start].name;*/ //いらんかも（長田）
        Debug.Log("駅数:" + ekisuu);
        /*go.text = es.sheets[0].list[goal].name;*/　//いらんかも（長田）

        //もし駅がなかったらの処理が必要  

        SceneManager.LoadScene("ResultScene");　//次のシーンに飛ぶ。次のシーンの名前を書く（長田）
    }
}
