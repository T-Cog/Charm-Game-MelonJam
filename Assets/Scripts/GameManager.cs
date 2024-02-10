using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject charmManager;
    public GameObject finishCharmButton;
    public GameObject finishDialogueButton;

    public GameObject[] dialogueTriggers;

    bool trigger1 = false;
    bool trigger2 = false;
    bool trigger3 = false;

    void Start()
    {
        for (int i = 0; i < dialogueTriggers.Length; i++)
        {
            dialogueTriggers[i].gameObject.SetActive(false);
        }

        dialogueTriggers[0].gameObject.SetActive(true);
    }

    
    void Update()
    {
        //Intro Check
        if (finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 1 && 
            trigger1 == false) 
        {
            Debug.Log("Racoon intro Triggered");
            dialogueTriggers[1].gameObject.SetActive(true);

            finishDialogueButton.SetActive(false);
            trigger1 = true;
        }  
        

        //Racoon Check
        if (finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 2 && 
            charmManager.GetComponent<CharmManager>().primeCharmId == 4 && 
            trigger2 == false)
        {
            Debug.Log("Racoon Good Triggered");
            dialogueTriggers[2].gameObject.SetActive(true);

            finishDialogueButton.SetActive(false);
            trigger2 = true;
        }
        else if (finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 2 && 
            charmManager.GetComponent<CharmManager>().primeCharmId != 4 &&
            trigger2 == false)
        {
            Debug.Log("Racoon Bad Triggered");
            dialogueTriggers[3].gameObject.SetActive(true);

            finishDialogueButton.SetActive(false);
            trigger2 = true;
        }

        //Cat Check
        if (finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 3 &&
            charmManager.GetComponent<CharmManager>().primeCharmId == 3 &&
            trigger3 == false)
        {
            Debug.Log("Cat Good Triggered");
            dialogueTriggers[4].gameObject.SetActive(true);

            finishDialogueButton.SetActive(false);
            trigger2 = true;
        }
        else if (finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 3 && 
            charmManager.GetComponent<CharmManager>().primeCharmId != 3 &&
            trigger3 == false)
        {
            Debug.Log("Cat Bad Triggered");
            dialogueTriggers[5].gameObject.SetActive(true);

            finishDialogueButton.SetActive(false);
            trigger2 = true;
        }
    }
}
