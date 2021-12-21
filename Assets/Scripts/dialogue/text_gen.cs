using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class text_gen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject XR_rig;
    private score score_script;
    public GameObject AliceBox;
    public GameObject QueenBox;
    public GameObject continueButton;
    public TMP_Text Name;
    public TMP_Text contents;
    public GameObject key;
    public string[,] dialogues;
    public bool checker = false;
    public bool checker2 = false;
    public int counter = 0;
    void Start()
    {
        score_script = XR_rig.GetComponent<score>();
        dialogues = new string[,]{{"Alice", "Your highness, you must be Queen of Heart?"}, {"Queen of Heart", "Yes sweetheart, anything that I could help you with?"}, {"Alice", "I want to get out of this Wonderland your highness, can you tell me where to go?"}, {"Queen of Heart", "Get me three roses. Walk around this garden and complete the riddles. You will earn one rose after you successfully complete a riddle."}, {"Queen of Heart","Thank you sweetheart, no one could ever complete all those quests."}, {"Queen of Heart","Here, take this key to unlock the gate."}, {"Queen of Heart", "Wait…I think I see something in your pocket. Is that….a white rose?!"}, {"Alice", "Yes, Mr.Hatter gave me. Do you want it as well?"}, {"Queen of Heart", "I hate white roses! Don’t you dare bring that thing into my kingdom! leave my kingdom right now!! Or there shall be a grave with your name on it !!"}};
    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= 8) {    
            Name.text = dialogues[counter,0];
            contents.text = dialogues[counter,1];
            if (Name.text == "Alice") {
                AliceBox.SetActive(true);
                QueenBox.SetActive(false);
            } else if(Name.text == "Queen of Heart") {
                AliceBox.SetActive(false);
                QueenBox.SetActive(true);
            }
            if (counter == 3 && checker == false) {
                continueButton.SetActive(false);
                if (score_script.flowers == 3) {
                    checker = true;
                    continueButton.SetActive(true);
                }
            
            }
            if (counter == 5 && checker2 == false) {
                key.SetActive(true);
                checker2 = true;
            }
            if (counter == 8) {
                continueButton.SetActive(false);
            }
        } else {
            continueButton.SetActive(false);
        }
    }

    public void on_click() {
        counter += 1;
    }
}
