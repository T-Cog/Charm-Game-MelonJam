using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCanvas : MonoBehaviour
{
    public GameObject charmManager;

    [Header ("Canvases")]
    public GameObject charmCanvas;
  //  public GameObject charmObjects;
    public GameObject dialogueCanvas;

    [Header ("Anchors")]
    public GameObject screenCanvasAnchor;
    public GameObject screenObjectAnchor;
    public GameObject charmCanvasAnchor;
    public GameObject charmObjectAnchor;
    public GameObject dialogueCanvasAnchor;

    Vector3 screenCanAnchorPos;
    Vector3 screenObjAnchorPos;

    Vector3 charmCanPos;
    Vector3 charmObjPos;
    Vector3 dialogueCanPos;

    [Range(0f, 1f)] 
    public float transitionSpeed = 0.5f;

   // bool dialogueActive = false;

    // Start is called before the first frame update
    void Start()
    {
        screenCanAnchorPos = screenCanvasAnchor.transform.position;
        screenObjAnchorPos = screenObjectAnchor.transform.position;

        charmCanPos = charmCanvas.transform.position;
       // charmObjPos = charmObjects.transform.position;
        dialogueCanPos = dialogueCanvas.transform.position;
    }


    public void FinishDialogue()
    {
        dialogueCanvas.transform.position = dialogueCanvasAnchor.transform.position; //Vector3.Lerp(dialogueCanPos, dialogueCanvasAnchor.transform.position, transitionSpeed);
        charmCanvas.transform.position = screenCanAnchorPos; //Vector3.Lerp(charmCanPos, screenCanAnchorPos, transitionSpeed);
      //  charmObjects.transform.position = screenObjectAnchor.transform.position; //Vector3.Lerp(charmObjPos, screenObjAnchorPos, transitionSpeed);

        charmManager.GetComponent<CharmManager>().primeCharmId = 0;
        charmManager.GetComponent<CharmManager>().secondCharmId = 0;
        charmManager.GetComponent<CharmManager>().thirdCharmId = 0;

        // Debug.Log("Charm Pos: " + charmCanPos);
        //Debug.Log("Dialogue Pos: " + dialogueCanPos);

       // dialogueActive = false;
    }

    public void FinishCharm()
    {
        charmCanvas.transform.position = charmCanvasAnchor.transform.position; //Vector3.Lerp(charmCanPos, charmCanvasAnchor.transform.position, transitionSpeed);
     //   charmObjects.transform.position = charmObjectAnchor.transform.position; //Vector3.Lerp(charmObjPos, charmObjectAnchor.transform.position, transitionSpeed);
        dialogueCanvas.transform.position = screenCanAnchorPos; //Vector3.Lerp(dialogueCanPos, screenCanAnchorPos, transitionSpeed);

      // Debug.Log("Charm Pos: " + charmCanPos);
      // Debug.Log("Dialogue Pos: " + dialogueCanPos);

       // dialogueActive = true;
    }

    

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Screen Anchor Pos: " + screenCanAnchorPos);
        //Debug.Log("Charm Anchor Pos: " + charmCanvasAnchor.transform.position);
        //Debug.Log("Dialogue Anchor Pos: " + dialogueAnchor.transform.position);
        
       // Debug.Log(dialogueActive);
        
        /* if(dialogueActive == true)
        {
            Debug.Log("If firing");
            charmCanvas.transform.position = charmCanPos;
            charmObjects.transform.position = charmObjPos;
            dialogueCanvas.transform.position = dialogueCanPos;
        } 
        else if(dialogueActive == false)
        {
            charmCanvas.transform.position = charmCanvas.transform.position;
            charmObjects.transform.position = charmObjects.transform.position;
            dialogueCanvas.transform.position = dialogueCanvas.transform.position;
        } */
            
        
    }
}
