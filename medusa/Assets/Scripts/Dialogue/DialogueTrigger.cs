using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogueUI;

    public void OnTriggerStay2D(Collider2D Player)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            triggerDialogue();
            dialogueUI.SetActive(true);
        }
    }

    public void triggerDialogue()
    {
        FindObjectOfType<DialogueManager>().startDialogue(dialogue);
    }
}
