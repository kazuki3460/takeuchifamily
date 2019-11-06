using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stampseat : MonoBehaviour
{
    public GameObject stamp1;
    public GameObject stamp2;
    public GameObject stamp3;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        y = stampscript.x;
        switch (y) {
            case 1: 
                stamp1.SetActive(true);
                break;
            case 2:
                stamp1.SetActive(true); 
                stamp2.SetActive(true);
                break;
            case 3:
                stamp1.SetActive(true);
                stamp2.SetActive(true);
                stamp3.SetActive(true);
                break;
        }

    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("FormScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
