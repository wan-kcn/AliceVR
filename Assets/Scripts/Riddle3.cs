using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddle3 : MonoBehaviour
{
    public TextMeshProUGUI word;
    public GameObject flower;
    public GameObject checkButton;
    void Start()
    {

    }

    public void onhit() {
        if (word.text == "TIME") {
            Debug.Log("true");
            flower.SetActive(true);
            checkButton.SetActive(false);
        }
    }
}