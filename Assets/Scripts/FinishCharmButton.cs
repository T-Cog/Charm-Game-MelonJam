using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCharmButton : MonoBehaviour
{
    public GameObject finishCharmButton;
    public GameObject charmManager;

    bool buttonCanActive = false;

    // Start is called before the first frame update
    void Start()
    {
        finishCharmButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Charm Button CanActive: " + buttonCanActive);

        if (charmManager.GetComponent<CharmManager>().primeActive && 
            charmManager.GetComponent<CharmManager>().secondActive && 
            charmManager.GetComponent<CharmManager>().thirdActive) 
        {
            buttonCanActive = true;
        } else
        {
            buttonCanActive = false;
        }
        
        if (buttonCanActive)
        {
            finishCharmButton.SetActive(true);
        } else
        {
            finishCharmButton.SetActive(false);
        }
    }
}
