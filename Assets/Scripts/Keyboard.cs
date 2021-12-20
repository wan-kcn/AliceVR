using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI word;
    public string key;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void on_press() {
        word.text = word.text + key;
    }
}
