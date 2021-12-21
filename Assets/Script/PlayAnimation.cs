using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject dialog;
    // void Start(){
    //     animator = GetComponent<Animator>();
    // }
    void OnTriggerEnter(Collider other){
        animator.SetBool("Goal",true);
        dialog.GetComponent<DialogueTrigger>().TriggerDialogue();
    }
}
