using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class arrive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("StampScene");
    }
    // Update is called once per frame
    void Update()
    {

    }
}