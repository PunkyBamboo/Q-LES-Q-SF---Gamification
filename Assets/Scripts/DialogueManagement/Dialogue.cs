using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public GameObject[] dialogues;

    public FinalRewardManagement finalRewardManagement;
    public string finalRewardPartName;
    public GameObject questRewardPopup;
    public TMP_Text questRewardPopupText;
    public GameObject cancelButton; // cancel dialogue button

    public bool isQuestFinish = false;  // tick if finishing this dialogue completes a quest
    // public LevelSystem levelSystem;
    // public int xpGain = 80;
    // public FinishedQuest finishedQuest;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextDialogue() {
        // go through the array of dialogues in scene
        for (int i = 0; i < dialogues.Length; i++) {
            // if the dialogue is active
            if(dialogues[i].activeInHierarchy) {
                dialogues[i].SetActive(false);  // hide it
                // check if this was the last dialogue
                // as in; i + 1 would give an out of range exception
                if(i+1 < dialogues.Length) { // if not
                    dialogues[i+1].SetActive(true); // show the next dialogue
                    break;
                }
                // gameObject.SetActive(false);
                // if it was the last
                if(isQuestFinish) {
                    dialogues[i].SetActive(false);
                    cancelButton.SetActive(false);
                    // finishedQuest.questIsFinished();
                    // levelSystem.addExperience(xpGain);  // gain xp
                    gainFinalRewardPart();  // gain a part for the final reward
                }
                break;  // end the dialogue
            }
        }
    }

    public void stopDialogue() {
        // go through the array of dialogues in scene
        for (int i = 0; i < dialogues.Length; i++) {
            dialogues[i].SetActive(false);
        }
        dialogues[0].SetActive(true);
    }
    
    // give the player one part of the final reward
    public void gainFinalRewardPart() {
        questRewardPopup.SetActive(true);
        finalRewardManagement.addFinalRewardPart();
        questRewardPopupText.SetText("Herzlichen Glückwunsch!\nDu hast " + finalRewardPartName + " erhalten!");
        // questRewardPopup.SetActive(true);

        // if player collected all rewards
        if(PlayerDataManagement.collectedFinalRewardParts >= PlayerDataManagement.overallFinalRewardParts) {
            SceneManager.LoadScene("04_Ending");    // go to the ending scene
        }
    }
}