using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedQuest : MonoBehaviour
{
    public int xpGain = 80;
    public LevelSystem levelSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void questIsFinished() {
        Debug.Log("Quest Done; previous xp: " + PlayerDataManagement.playerXP);
        // PlayerDataManagement.playerXP += xpGain;
        levelSystem.addExperience(xpGain);
        Debug.Log("new xp: " + PlayerDataManagement.playerXP);
    }
}
