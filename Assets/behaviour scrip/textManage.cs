using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class textManage : MonoBehaviour
{
    public TMP_Text rabitText;

    void Start()
    {
        rabitText.alignment = TextAlignmentOptions.Center;
    }

    void Update()
    {
        int count = GameObject.Find("rabitBody").GetComponent<rabitMovement>().count;
        string status = GameObject.Find("rabitBody").GetComponent<rabitMovement>().rabbit_status;
        string wait_status = GameObject.Find("rabitBody").GetComponent<rabitMovement>().wait_status;

        rabitText.text = count.ToString();

        if(status == "moving" && wait_status == "false"){
            rabitText.gameObject.SetActive(false);
        }else if(status == "stop" && wait_status == "true"){
            rabitText.gameObject.SetActive(true);
        }

        if(count >= 10){
            this.gameObject.SetActive(false);
        }
    }
}
