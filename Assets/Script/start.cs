using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject dialog;
    // void Start(){
    //     animator = GetComponent<Animator>();
    // }
    void OnTriggerEnter(Collider other){
        dialog.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
}
