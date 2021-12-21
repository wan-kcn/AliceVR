using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endText : MonoBehaviour
{
    [SerializeField] private GameObject aliceText;
    [SerializeField] private GameObject madText;
    [SerializeField] private GameObject madModel;
    private int num = 1;
    public string wait_status = "false";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void wait () {
        if(num == 1){
            aliceText.gameObject.SetActive(true);
            madText.gameObject.SetActive(false);
            madModel.gameObject.SetActive(false);
        }
        if(num == 2){
            aliceText.gameObject.SetActive(false);
            madText.gameObject.SetActive(true);
            madModel.gameObject.SetActive(true);
        }
        // if(num > 2){
        //     aliceText.gameObject.SetActive(false);
        //     madText.gameObject.SetActive(false);
        // }
        num++;
    }

    IEnumerator Countdown (int seconds) {
        wait_status = "true";
        int counter = seconds;
        while (counter > 0) {
        yield return new WaitForSeconds (1);
            counter--;
        }
        wait_status = "false";
        wait ();
    }

    // Update is called once per frame
    void Update()
    {
        if(wait_status == "false"){
            StartCoroutine(Countdown(2));
        }
    }
}
