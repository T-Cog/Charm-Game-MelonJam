using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CharmSelector : MonoBehaviour
{
    public bool selected = false;
    public int charmId;

    public GameObject charmManager;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharmSelected()
    {
        Debug.Log("Charm Selected " + charmId);
        selected = true;
        charmManager.GetComponent<CharmManager>().currentCharmId = charmId;
    }
}
