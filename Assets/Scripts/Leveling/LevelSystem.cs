using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class LevelSystem : MonoBehaviour
{
    public TMP_Text xpBarText;  // text to show current xp
    public Scrollbar xpBar; // xp bar
    public TMP_Text levelText;  // text to show current level
    public GameObject xpGainedPopup;    // popup to show when you gain xp
    public TMP_Text xpGainedText;   // text to show the gained xp
    public string filePath = "UserData/finalUserProgress.txt";    // file to save level to

    private string xpLabel = " XP";
    private string levelLabel = "Level ";
    // Start is called before the first frame update
    void Start()
    {
        xpBarText.SetText(PlayerDataManagement.playerXP.ToString() + xpLabel);
        levelText.SetText(levelLabel + PlayerDataManagement.playerLevel.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // get current amount of xp
    public int getXP() {
        return PlayerDataManagement.playerXP;
    }

    // get current level
    public int getLevel() {
        return PlayerDataManagement.playerLevel;
    }

    // add xp points
    public void addExperience(int experienceToAdd) {
        Debug.Log("Previous xp: " + PlayerDataManagement.playerXP);
        PlayerDataManagement.playerXP += experienceToAdd;  // increase xp
        Debug.Log("New xp: " + PlayerDataManagement.playerXP);

        // show player how much xp they earned
        StartCoroutine(displayXPGain(experienceToAdd));

        Debug.Log("xpBar size: " + PlayerDataManagement.playerXP / PlayerDataManagement.xpToNextLevel);
        xpBar.size = (float) PlayerDataManagement.playerXP / (float) PlayerDataManagement.xpToNextLevel;

        // if player has enough xp to level
        if(PlayerDataManagement.playerXP >= PlayerDataManagement.xpToNextLevel) {
            Debug.Log("Previous Level: " + PlayerDataManagement.playerLevel);
            increaseLevel(1);   // increase the lvl by one
            Debug.Log("New Level: " + PlayerDataManagement.playerLevel);
        }
        updateLevelandXP();
    }

    // increase the player level
    public void increaseLevel(int amountToIncrease) {
        PlayerDataManagement.playerLevel += amountToIncrease; // increase the level by specified amount
        PlayerDataManagement.playerXP = PlayerDataManagement.playerXP - PlayerDataManagement.xpToNextLevel;    // remove the xp needed to level up to get the new xp amount
        // xpBar.size = amountToIncrease;
        xpBar.size = (float) PlayerDataManagement.playerXP / (float) PlayerDataManagement.xpToNextLevel;
    }

    public void updateLevelandXP() {
        xpBarText.SetText(PlayerDataManagement.playerXP.ToString() + xpLabel);
        levelText.SetText(levelLabel + PlayerDataManagement.playerLevel.ToString());
    }

    // shows the player how much xp they just got
    public IEnumerator displayXPGain(int xpGained) {
        xpGainedPopup.SetActive(true);
        xpGainedText.SetText("You've gained " + xpGained.ToString() + " experience points!");  // set the text to the xp gained
        yield return new WaitForSeconds(3); // wait 3 seconds
        xpGainedPopup.SetActive(false);
    }

    // if we want to save the final level of the user
    public void saveToFile() {
        File.AppendAllText(filePath, System.String.Format("Final Level: " + PlayerDataManagement.playerLevel + "\n")); // add the text to the specified file
    }
}
