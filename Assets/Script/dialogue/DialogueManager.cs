using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<Dialogue> sentences;
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<Dialogue>();
    }

    public void StartDialogue(Dialogue[] dialogues){
        sentences.Clear();
        foreach (Dialogue d in dialogues){
            // Debug.Log("Starting conversation with " + dialogue.name);

            // nameText.text = dialogue.name;

            
            sentences.Enqueue(d);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentences.Count==0){
            EndDialog();
            return;
        }
        
        Dialogue d = sentences.Dequeue();
        Debug.Log(d.name);
        dialogueText.text = d.sentence;
        nameText.text = d.name;

    }

    void EndDialog(){
        Debug.Log("End of conversation.");
        textBox.SetActive(false);
    }
}
