using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject triggerAnchor;

    public Message[] messages;
    public Actor[] actors;
    

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
        enabled = false;
        transform.position = triggerAnchor.transform.position;
    }
}

    [System.Serializable]
    public class Message
    {
        public int actorId;
        public string message;
    }

    [System.Serializable]
    public class Actor
    {
        public string name;
        public Sprite sprite;
    }
