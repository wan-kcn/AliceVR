using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class textManage : MonoBehaviour
{
    public TMP_Text rabitText;

    // Start is called before the first frame update
    void Start()
    {
        rabitText.alignment = TextAlignmentOptions.Center;
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.Find("rabitBody").GetComponent<rabitMovement>().count;
        string status = GameObject.Find("rabitBody").GetComponent<rabitMovement>().rabbit_status;

        rabitText.text = count.ToString();

        if(status == "moving"){
            rabitText.GetComponent<MeshRenderer>().enabled = false;
        }else{
            rabitText.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
