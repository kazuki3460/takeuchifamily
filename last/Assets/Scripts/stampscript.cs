using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stampscript : MonoBehaviour
{
    public Text stampname;
    public GameObject tokyo;
    public GameObject kanda;
    public GameObject akibahara;
    public GameObject okachimachi;
    public GameObject ueno;
    public GameObject uguisudani;
    public GameObject nippori;
    public GameObject nisinippori;
    public GameObject tabata;
    public GameObject komagome;
    public GameObject sugamo;
    public GameObject otuka;
    public GameObject ikebukuro;
    public GameObject meziro;
    public GameObject takadanobaba;
    public GameObject sinnokubo;
    public GameObject sinzyuku;
    public GameObject yoyogi;
    public GameObject harazyuku;
    public GameObject sibuya;
    public GameObject ebisu;
    public GameObject meguro;
    public GameObject gotanda;
    public GameObject osaki;
    public GameObject sinagawa;
    public GameObject takanawagateway;
    public GameObject tamachi;
    public GameObject hamamatsucho;
    public GameObject sinbasi;
    public GameObject yurakucho;
    public static int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Test.SampleGoal == "東京")
        {
            tokyo.SetActive(true);
        }
        else if (Test.SampleGoal == "神田")
        {
            kanda.SetActive(true);
        }
        else if (Test.SampleGoal == "秋葉原")
        {
            akibahara.SetActive(true);
        }
        else if (Test.SampleGoal == "御徒町")
        {
            okachimachi.SetActive(true);
        }
        else if (Test.SampleGoal == "上野")
        {
            ueno.SetActive(true);
        }
        else if (Test.SampleGoal == "鶯谷")
        {
            uguisudani.SetActive(true);
        }
        else if (Test.SampleGoal == "日暮里")
        {
            nippori.SetActive(true);
        }
        else if (Test.SampleGoal == "西日暮里")
        {
            nisinippori.SetActive(true);
        }
        else if (Test.SampleGoal == "田端")
        {
            tabata.SetActive(true);
        }
        else if (Test.SampleGoal == "駒込")
        {
            komagome.SetActive(true);
        }
        else if (Test.SampleGoal == "巣鴨")
        {
            sugamo.SetActive(true);
        }
        else if (Test.SampleGoal == "大塚")
        {
            otuka.SetActive(true);
        }
        else if (Test.SampleGoal == "池袋")
        {
            ikebukuro.SetActive(true);
        }
        else if (Test.SampleGoal == "目白")
        {
            meziro.SetActive(true);
        }
        else if (Test.SampleGoal == "高田馬場")
        {
            takadanobaba.SetActive(true);
        }
        else if (Test.SampleGoal == "新大久保")
        {
            sinnokubo.SetActive(true);
        }
        else if (Test.SampleGoal == "新宿")
        {
            sinzyuku.SetActive(true);
        }
        else if (Test.SampleGoal == "代々木")
        {
            yoyogi.SetActive(true);
        }
        else if (Test.SampleGoal == "原宿")
        {
            harazyuku.SetActive(true);
        }
        else if (Test.SampleGoal == "渋谷")
        {
            sibuya.SetActive(true);
        }
        else if (Test.SampleGoal == "恵比寿")
        {
            ebisu.SetActive(true);
        }
        else if (Test.SampleGoal == "目黒")
        {
            meziro.SetActive(true);
        }
        else if (Test.SampleGoal == "五反田")
        {
            gotanda.SetActive(true);
        }
        else if (Test.SampleGoal == "大崎")
        {
            osaki.SetActive(true);
        }
        else if (Test.SampleGoal == "品川")
        {
            sinagawa.SetActive(true);
        }
        else if (Test.SampleGoal == "高輪ゲートウェイ")
        {
            takanawagateway.SetActive(true);
        }
        else if (Test.SampleGoal == "田町")
        {
            tamachi.SetActive(true);
        }
        else if (Test.SampleGoal == "浜松町")
        {
            hamamatsucho.SetActive(true);
        }
        else if (Test.SampleGoal == "新橋")
        {
            sinbasi.SetActive(true);
        }
        else if (Test.SampleGoal == "有楽町")
        {
            yurakucho.SetActive(true);
        }
        else
        {
            Debug.Log("不適切なアクセスです"); 
        }

        stampname.text = Test.SampleGoal;
    }
public void PushStartButton() {
        SceneManager.LoadScene("StampseatScene");
        x = x + 1;
        Debug.Log(x);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
