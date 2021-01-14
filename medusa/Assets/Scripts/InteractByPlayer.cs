using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractByPlayer : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    public GameObject dialogueUI;

    public void OnTriggerStay2D(Collider2D Player)
    {     
        if (Input.GetKey(KeyCode.Space))
        {
            dialogueTrigger.triggerDialogue();
            Debug.Log("This works");
            dialogueUI.SetActive(true);
        }
    }
}
