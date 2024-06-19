using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreasePoints : MonoBehaviour
{
    public PointSystem PointSystem; // call to the point system script to be able to use its methods
    public int amountToIncrease = 100;   // amount to increase points by; change this in the unity ui!!

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(addPoints); // on press increase the points
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addPoints() {
        PointSystem.addPoints(amountToIncrease);    // increase the points
        PointSystem.updatePoints(); // update the visuals

        // check if threehundred points achievement exists
        /* if( AchievementManager.instance.AchievementExists("threehundred_points")) {
            AchievementManager.instance.AddAchievementProgress("threehundred_points", amountToIncrease);    // add progress to achievement

            // if requirements are met unlock the achievement
            if(PointSystem.getPoints() >= 300) {
                AchievementManager.instance.Unlock("threehundred_points");
            }
        } */
    }
}
