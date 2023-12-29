using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmManager : MonoBehaviour
{
    /*
    public GameObject[] primaryPieces;
    public GameObject[] secondaryPieces;
    public GameObject[] tertiaryPieces;

    int currentPrimaryPiece;
    int currentSecondaryPiece;
    int currentTertiaryPiece;
    */

    public GameObject[] infoText;

    public Sprite[] primaryPieces;
    public Sprite[] secondaryPieces;
    public Sprite[] tertiaryPieces;

    public SpriteRenderer primarySprite;
    public SpriteRenderer secondarySprite;
    public SpriteRenderer tertiarySprite;

    public GameObject primaryCharm;
    public GameObject secondaryCharm;
    public GameObject tertiaryCharm;

    public int currentCharmId;

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
        

        Debug.Log(currentCharmId);

        if (currentCharmId == 1)
        {
            primarySprite.sprite = primaryPieces[0];

            infoText[0].SetActive(true);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        }  
        else if (currentCharmId == 2)
        {
            primarySprite.sprite = primaryPieces[1];

            infoText[1].SetActive(true);
            infoText[0].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        }
        else if (currentCharmId == 3)
        {
            primarySprite.sprite = primaryPieces[2];

            infoText[2].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[3].SetActive(false);
            infoText[4].SetActive(false);
        } 
        else if (currentCharmId == 4)
        {
            primarySprite.sprite= primaryPieces[3];

            infoText[3].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[4].SetActive(false);
        }
        else if (currentCharmId == 5)
        {
            primarySprite.sprite = primaryPieces[4];

            infoText[4].SetActive(true);
            infoText[0].SetActive(false);
            infoText[1].SetActive(false);
            infoText[2].SetActive(false);
            infoText[3].SetActive(false);
        }
        //Secondary Sprites
        else if (currentCharmId == 6)
        {
            secondarySprite.sprite = secondaryPieces[0];
        }
        else if (currentCharmId == 7)
        {
            secondarySprite.sprite= secondaryPieces[1];
        }
        else if (currentCharmId == 8)
        {
            secondarySprite.sprite = secondaryPieces[2];
        }
        //Tertiary Sprites
        else if (currentCharmId == 9)
        {
            tertiarySprite.sprite = tertiaryPieces[0];
        }
        else if (currentCharmId == 10)
        {
            tertiarySprite.sprite= tertiaryPieces[1];
        }
        else if (currentCharmId == 11)
        {
            tertiarySprite.sprite = tertiaryPieces[2];
        }
        
    }

}
