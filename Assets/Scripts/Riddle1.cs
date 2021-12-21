using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddle1 : MonoBehaviour
{
    public TextMeshProUGUI word;
    public GameObject flower;
    public GameObject checkButton;

    public GameObject correct;
    public GameObject incorrect;

    void Start()
    {
    }

    public void onhit() {
        if (word.text == "HOURGLASS" || word.text == "SANDGLASS" || word.text == "SANDCLOCK") {
            Debug.Log("true");
            flower.SetActive(true);
            correct.SetActive(true);
            checkButton.SetActive(false);
        } else {
            incorrect.SetActive(true);
            StartCoroutine(Countdown(2));
        }
    }

    IEnumerator Countdown(int seconds) {
        yield return new WaitForSeconds(seconds);
        incorrect.SetActive(false);
    } 
}
