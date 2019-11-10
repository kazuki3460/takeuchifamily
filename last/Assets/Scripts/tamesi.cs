using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//追加（長田）
using UnityEngine.SceneManagement;　//追加（正直いらん）（長田）
using System; //追加（長田）
using System.IO;　//追加（長田）

public class tamesi : MonoBehaviour
{
    //オブジェクトとの結び付け（長田）
    public Text st;
    public Text go;
    public Text num;

    // Start is called before the first frame update
    void Start()
    {
        //Testで代入した内容を当てはめてる（長田）
        st.text = Test.SampleStart;
        go.text = Test.SampleGoal;
        num.text = Test.ekisuu.ToString(); ;
        
    }
    public void PushStartButton()
    {
        SceneManager.LoadScene("ConfirmScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
