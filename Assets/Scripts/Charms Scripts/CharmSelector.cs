using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CharmSelector : MonoBehaviour
{
   // public bool selected = false;
    public int primeCharmId = 0;
    public int secondCharmId = 0;
    public int thirdCharmId = 0;

    public GameObject charmManager;

    public void PrimeCharmSelected()
    {
        //Debug.Log("Charm Selected " + primeCharmId);
      //  selected = true;
        charmManager.GetComponent<CharmManager>().primeCharmId = primeCharmId;
    }

    public void SecondaryCharmSelected()
    {
        //Debug.Log("Charm Selected " + secondCharmId);
        //  selected = true;
        charmManager.GetComponent<CharmManager>().secondCharmId = secondCharmId;
    }

    public void TertiaryCharmSelected()
    {
        //Debug.Log("Charm Selected " + thirdCharmId);
        //  selected = true;
        charmManager.GetComponent<CharmManager>().thirdCharmId = thirdCharmId;
    }
}
