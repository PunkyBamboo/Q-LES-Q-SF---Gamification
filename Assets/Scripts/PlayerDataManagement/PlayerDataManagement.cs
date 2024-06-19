using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

// manages name, avatar, etc of the player
// public static class PlayerDataManagement : MonoBehaviour {
public static class PlayerDataManagement {
    // public TMP_Text playerNameSetter;
    public static string playerName = "Player";
    public static int playerXP = 0;
    public static int xpToNextLevel = 50;
    public static int playerLevel = 1;
    public static int playerPoints = 0;

    public static int collectedFinalRewardParts = 0;    // how many parts of the final reward the player has collected currently
    public static int overallFinalRewardParts = 16;    // how many questions that need to be answered to get the final reward

    // check if player answered enough questions to get the final reward
    public static bool isFinalRewardDone() {
        if(collectedFinalRewardParts >= overallFinalRewardParts) {
            return true;
        } else {
            return false;
        }
    }
}
