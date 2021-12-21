using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Manager;
    public Dialogue[] dialogues;

    public void TriggerDialogue(){
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogues);
        Manager.GetComponent<DialogueManager>().StartDialogue(dialogues);
    }
}
