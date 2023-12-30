using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionCounter : MonoBehaviour
{
    public int finishedCharms = 0;

    public void IncreasCounter()
    {
        finishedCharms++;
    }

    private void Update()
    {
        Debug.Log("Finished Charms: " + finishedCharms);
    }
}
