using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWith : MonoBehaviour
{
    private GameObject player;  // player object
    public GameObject dialogueToStart;  // dialogue that should start when interacting
    public GameObject cancelButton; // cancel dialogue button
    public GameObject questIndicator;  // indicator that npc has quest
    private bool isDialogueTriggered;   // to make sure the dialogue only triggers once

    // Start is called before the first frame update
    void Start()
    {
        // questIndicator = GameObject.FindGameObjectsWithTag("Quest Indicator")[0];
        player = GameObject.FindGameObjectsWithTag("Player")[0];    // assign the player object
        isDialogueTriggered = false;
    }

    void Update()
    {
        // check if the player is in range AND if the key has been pressed
        if (Input.GetKeyDown(KeyCode.F) && isInRange())
        {
            // check if the dialogue has not been triggered yet
            if (!isDialogueTriggered)
            {
                dialogueToStart.SetActive(true);
                cancelButton.SetActive(true);
                questIndicator.SetActive(false);
                isDialogueTriggered = true;
            }
        }
    }

    // check if player is in range
    bool isInRange()
    {
        if (gameObject.GetComponent<CapsuleCollider2D>().IsTouching(player.GetComponent<CapsuleCollider2D>()))
        {   // check if the colliders are touching
            return true;
        }
        else
        {
            return false;
        }
    }

    // allows dialogue to trigger again
    public void resetDialogue()
    {
        isDialogueTriggered = false;
        questIndicator.SetActive(true);
        dialogueToStart.SetActive(false);
    }
}
