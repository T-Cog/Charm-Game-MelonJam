using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmManager : MonoBehaviour
{
    [Header ("Info Text List")]
    public GameObject[] infoText;

    public Sprite[] primaryPieces;
    public Sprite[] secondaryPieces;
    public Sprite[] tertiaryPieces;

    [Header ("Sprite Renderers")]
    public SpriteRenderer primarySprite;
    public SpriteRenderer secondarySprite;
    public SpriteRenderer tertiarySprite;

    [Header("Charm Containers")]
    public GameObject primaryCharm;
    public GameObject secondaryCharm;
    public GameObject tertiaryCharm;

    [Header ("Charm Data")]
    public int primeCharmId;
    public int secondCharmId;
    public int thirdCharmId;

    public bool primeActive = false;
    public bool secondActive = false;
    public bool thirdActive = false;

    // Start is called before the first frame update
    void Start()
    {
        primarySprite = primaryCharm.GetComponent<SpriteRenderer>();
        secondarySprite = secondaryCharm.GetComponent<SpriteRenderer>();
        tertiarySprite = tertiaryCharm.GetComponent<SpriteRenderer>();

        for (int i = 0; i < infoText.Length; i++)
        {
            infoText[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Prime Charm Id: " + primeCharmId);

        Debug.Log("Prime Active: " + primeActive);
        Debug.Log("Second Active: " + secondActive);
        Debug.Log("Third Active: " + thirdActive);

        //Primary Sprites
        if (primeCharmId == 0)
        {
            primarySprite.sprite = null;
            primeActive = false;
        }
        else if (primeCharmId == 1)
        {
            primeActive = true;
            primarySprite.sprite = primaryPieces[0];

            infoText[0].SetActive(true);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        }  
        else if (primeCharmId == 2)
        {
            primeActive = true;
            primarySprite.sprite = primaryPieces[1];

            infoText[1].SetActive(true);
            infoText[0].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        }
        else if (primeCharmId == 3)
        {
            primeActive = true;
            primarySprite.sprite = primaryPieces[2];

            infoText[2].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        } 
        else if (primeCharmId == 4)
        {
            primeActive = true;
            primarySprite.sprite= primaryPieces[3];

            infoText[3].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[4].SetActive(false);
        }
        else if (primeCharmId == 5)
        {
            primeActive = true;
            primarySprite.sprite = primaryPieces[4];

            infoText[4].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
        }
        
        //Secondary Sprites
        if (secondCharmId == 0)
        {
            secondarySprite.sprite = null;
            secondActive = false;
        }
        else if (secondCharmId == 1)
        {
            secondActive = true;
            secondarySprite.sprite = secondaryPieces[0];
        }
        else if (secondCharmId == 2)
        {
            secondActive = true;
            secondarySprite.sprite= secondaryPieces[1];
        }
        else if (secondCharmId == 3)
        {
            secondActive = true;
            secondarySprite.sprite = secondaryPieces[2];
        }


        //Tertiary Sprites
        if (thirdCharmId == 0)
        {
            tertiarySprite.sprite = null;
            thirdActive = false;
        }
        else if (thirdCharmId == 1)
        {
            thirdActive = true;
            tertiarySprite.sprite = tertiaryPieces[0];
        }
        else if (thirdCharmId == 2)
        {
            thirdActive = true;
            tertiarySprite.sprite= tertiaryPieces[1];
        }
        else if (thirdCharmId == 3)
        {
            thirdActive = true;
            tertiarySprite.sprite = tertiaryPieces[2];
        }
        
    }

}
