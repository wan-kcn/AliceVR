using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Riddle1 : MonoBehaviour
{
    public TextMeshProUGUI word;
    void Start()
    {
    }

    public void onhit() {
        if (word.text == "HOURGLASS" || word.text == "SANDGLASS" || word.text == "SANDCLOCK") {
            Debug.Log("true");
        }
    }
}
