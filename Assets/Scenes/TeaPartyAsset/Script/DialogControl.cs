using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    public GameObject[] TextObj;
    public TextMeshProUGUI[] DialogText;
    //0: Alice, 1:Mad Hatter, 2:Rabbit, 3: Alice(body) 4: Mad Hatter Body:

    public Button NextButton;

    // Start is called before the first frame update

    public int currentIndex = 0;

    void Start()
    {
        NextButton.gameObject.SetActive(false);
        TextObj[4].SetActive(false);
        TextObj[3].SetActive(false);
        TextObj[2].SetActive(false);
        TextObj[1].SetActive(false);
        DialogScriptControl(currentIndex);
    }

    public void ChangeDialog()
    {
        currentIndex++;
        DialogScriptControl(currentIndex);
    }

    void DialogScriptControl(int index)
    {
        switch (index)
        {
            case 0:
                TextObj[4].SetActive(true);
                DialogText[4].text = "Where am I?";

                StartCoroutine(AutoClick());

                break;
            case 1:
                DialogText[4].text = " Ahh that bunny is gone again.";

                StartCoroutine(AutoClick());

                break;

            case 2:
                TextObj[3].SetActive(false);
                NextButton.gameObject.SetActive(true);
                TextObj[2].SetActive(true);
                TextObj[1].SetActive(true);
                TextObj[0].SetActive(true);
                DialogText[2].text = "Hey! Who are you and why are you here?!";
                DialogText[1].text = "...";
                DialogText[0].text = "...";
                break;

            case 3:
                DialogText[2].text = "...";
                DialogText[1].text = "It’s clear that she followed you.";
                DialogText[0].text = "...";
                break;

            case 4:
                DialogText[2].text = "You gotta be kidding me.";
                DialogText[1].text = "...";
                DialogText[0].text = "...";
                break;

            case 5:
                DialogText[2].text = "...";
                DialogText[1].text = "Nope, and Bunny you are late for the tea party again.";
                DialogText[0].text = "...";
                break;

            case 6:
                DialogText[2].text = "It’s not my fault.";
                DialogText[1].text = "...";
                DialogText[0].text = "...";
                break;

            case 7:
                DialogText[2].text = "...";
                DialogText[1].text = "...";
                DialogText[0].text = "Excuse me, who are you and where am I?";
                break;

            case 8:
                DialogText[2].text = "...";
                DialogText[1].text = "This is Wonderland sweetie but that’s not important. What’s more important is you have to get out of here before the Queen arrives at the tea party.";
                DialogText[0].text = "...";
                break;

            case 9:
                DialogText[2].text = "...";
                DialogText[1].text = "...";
                DialogText[0].text = "How? I just followed the bunny here.";
                break;

            case 10:
                DialogText[2].text = "...";
                DialogText[1].text = "Actually, I know how you can get out of this wonderland.";
                DialogText[0].text = "...";
                break;

            case 11:
                DialogText[2].text = "...";
                DialogText[1].text = "...";
                DialogText[0].text = "Just collect List of item on the table then find me and I will get you out of here.";
                NextButton.gameObject.SetActive(false);
                StartCoroutine(CloseDialog());
                break;

            case 12:
                TextObj[4].SetActive(true);
                TextObj[3].SetActive(true);
                DialogText[4].text = " Nice work! Now I will tell you the way. Walk through this door and you will find the Heart Castle. There you will have to solve some riddles and games.";
                DialogText[3].text = "...";
                break;

            case 13:
                DialogText[4].text = "After completing each session you will receive a red rose. Collect three roses and go to the center of the Heart Castle.";
                DialogText[3].text = "...";
                break;

            case 14:
                DialogText[4].text = "...";
                DialogText[3].text = "Thanks Mr.Hatter.";
                break;

            case 15:
                DialogText[4].text = "Oh! You might run into Queen of Heart on your way. Don’t be scared here, I will give you this white rose as a present :)";
                TextObj[3].SetActive(false);
                break;
        }
    }

    IEnumerator CloseDialog()
    {
        yield return new WaitForSeconds(1f);

        TextObj[3].SetActive(false);
        TextObj[2].SetActive(false);
        TextObj[1].SetActive(false);
        TextObj[0].SetActive(false);
    }

    IEnumerator AutoClick()
    {
        yield return new WaitForSeconds(1f);
         
        ChangeDialog();
    }
}
