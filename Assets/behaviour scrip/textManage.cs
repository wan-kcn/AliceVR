using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class textManage : MonoBehaviour
{
    public TMP_Text rabitText;
    public TMP_Text chaName;
    [SerializeField] private string dialog;
    [SerializeField] private RawImage box;
    private string[] cars= {"What a cute bunny!", "But, hmmm why is there a rabbit in the park?", "Are you lost from your owner, little guy?", "I think I should go closer.", "", "Wait! Don't run away from me!", "", "Hmm…. a cave in the park? I think that weird bunny might be inside."};

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

        if(count-1 <= 8){
            rabitText.text = dialog;
        }

        if(status == "moving" && wait_status == "false"){
            rabitText.gameObject.SetActive(false);
            box.gameObject.SetActive(false);
            chaName.gameObject.SetActive(false);
        }else if(status == "stop" && wait_status == "true"){
            rabitText.gameObject.SetActive(true);
            if(rabitText.text != ""){
                box.gameObject.SetActive(true);
                chaName.gameObject.SetActive(true);
            }
        }
        if(status == "stop" && wait_status == "false"){
            rabitText.gameObject.SetActive(false);
            box.gameObject.SetActive(false);
            chaName.gameObject.SetActive(false);
        }

        if(count >= 10){
            rabitText.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            box.gameObject.SetActive(false);
            chaName.gameObject.SetActive(false);
        }
    }
}
