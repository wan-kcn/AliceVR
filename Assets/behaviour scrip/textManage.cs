using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class textManage : MonoBehaviour
{
    public TMP_Text rabitText;
    [SerializeField] private string dialog;
    private string[] cars= {"Alice : What a cute bunny!", "Alice : But, hmmm why is there a rabbit in the park?", "Alice : Are you lost from your owner, little guy?", "Alice : I think I should go closer.", "", "Alice : Wait! Don't run away from me!", "", "Alice : Hmm…. a cave in the park? I think that weird bunny might be inside."};

    void Start()
    {
        rabitText.alignment = TextAlignmentOptions.Left;
    }

    void Update()
    {
        int count = GameObject.Find("rabitBody").GetComponent<rabitMovement>().count;
        string status = GameObject.Find("rabitBody").GetComponent<rabitMovement>().rabbit_status;
        string wait_status = GameObject.Find("rabitBody").GetComponent<rabitMovement>().wait_status;
        dialog = cars[count-1];

        rabitText.text = dialog;

        if(status == "moving" && wait_status == "false"){
            rabitText.gameObject.SetActive(false);
        }else if(status == "stop" && wait_status == "true"){
            rabitText.gameObject.SetActive(true);
        }
        if(status == "stop" && wait_status == "false"){
            rabitText.gameObject.SetActive(false);
        }

        if(count >= 10){
            rabitText.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
