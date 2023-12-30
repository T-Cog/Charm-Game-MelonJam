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
        if (charmManager.GetComponent<CharmManager>().primeCharmId == 1 && 
            finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 1 &&
            trigger1 == false) 
        {

            dialogueTriggers[2].gameObject.SetActive(true);
            Debug.Log("Good Trigger");

            finishDialogueButton.SetActive(false);
            trigger1 = true;
        } 
        else if (charmManager.GetComponent<CharmManager>().primeCharmId != 1 &&
            finishCharmButton.GetComponent<TransitionCounter>().finishedCharms == 1 &&
            trigger1 == false)
        {
            dialogueTriggers[3].gameObject.SetActive(true);
            Debug.Log("Bad Trigger");

            finishDialogueButton.SetActive(false);
            trigger1 = true;
        }

    }
}
