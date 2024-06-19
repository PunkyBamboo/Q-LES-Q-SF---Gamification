using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class PointSystem : MonoBehaviour
{
    private int points = 0; // current points
    public TMP_Text pointsText; // text to show current points
    public TMP_Text pointsGainedText;   // text to show the gained points
    public string filePath = "";    // file to save level to
    // Start is called before the first frame update
    void Start()
    {
        pointsText.SetText(points.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // get current amount of points
    public int getPoints() {
        return points;
    }

    // add xp points
    public void addPoints(int pointsToAdd) {
        points += pointsToAdd;  // increase points

        // show player how many points they earned
        // displayPointGain(pointsToAdd);
        StartCoroutine(displayPointGain(pointsToAdd));
    }

    public void updatePoints() {
        pointsText.SetText(points.ToString());
        saveToFile();
    }

    // shows the player how many points they just got
    public IEnumerator displayPointGain(int pointsGained) {
        pointsGainedText.SetText("You've gained " + pointsGained.ToString() + " points!");  // set the text to the points gained
        yield return new WaitForSeconds(3); // wait 3 seconds
        pointsGainedText.SetText("");   // hide the text
    }

    // if we want to save the final points of the user
    public void saveToFile() {
        File.AppendAllText(filePath, System.String.Format("Final Points: " + points + "\n")); // add the text to the specified file
    }
}
