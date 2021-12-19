using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DelKey : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI word;
    void Start()
    {
        
    }

    public void on_press() {
        if (word.text != null && word.text.Length > 0) {
            word.text = word.text.Substring(0, word.text.Length - 1);
        }
    }
}
