using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class SaveUserToggleGroup : MonoBehaviour
{
    // global variables
    private string input;   // for easier call of variable
    // public Toggle[] toggleGroup; // our toggle group object
    // private string filePath = "UserData/userAnswers.txt";
    private string filePath = "/userData/userAnswers.txt";
    public string textBeforeAnswer = "";
    public string textAfterAnswer = "";
    private string groupSeperator = "----------------------------";
    public string groupName = "New Group";
    public bool isGroupStart;
    public bool isGroupEnd;

    // Start is called before the first frame update
    void Start()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/userData");
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    public string firstToggleLabel = "";
    public string secondToggleLabel = "";
    public string thirdToggleLabel = "";
    public string fourthToggleLabel = "";
    public string fifthToggleLabel = "";

    // save the user input
    void saveUserInput() {
        foreach(var t in toggleGroup) {
            if(t.isOn) {
                string tString = t.ToString();  // convert toggle to string
                switch (tString) {
                    // if first toggle is selected
                    case "Toggle1 (UnityEngine.UI.Toggle)":
                        saveToFile(firstToggleLabel);   // save to file
                        break;
                    // if second toggle is selected
                    case "Toggle2 (UnityEngine.UI.Toggle)":
                        saveToFile(secondToggleLabel);   // save to file
                        break;
                    // if third toggle is selected
                    case "Toggle3 (UnityEngine.UI.Toggle)":
                        saveToFile(thirdToggleLabel); // save to file
                        break;
                    // if fourth toggle is selected
                    case "Toggle4 (UnityEngine.UI.Toggle)":
                        saveToFile(fourthToggleLabel); // save to file
                        break;
                    // if fifth toggle is selected
                    case "Toggle5 (UnityEngine.UI.Toggle)":
                        saveToFile(fifthToggleLabel); // save to file
                        break;
                }
            }
        }
    }
    */

    // get the user input
    public string getUserInput() {
        return input;
    }

    public void saveToFile(string text) {
        // check if this is the start of a new group
        startNewGroup();
        // add text
        File.AppendAllText(Application.streamingAssetsPath + filePath, System.String.Format(textBeforeAnswer + " " + text + textAfterAnswer + "\n")); // add the text to the specified file
        // check if this is the end of a group
        endGroup();
    }

    // if elements need to be grouped
    public void startNewGroup() {
        if(isGroupStart) {
            File.AppendAllText(Application.streamingAssetsPath + filePath, System.String.Format("\n" + groupSeperator + groupName + groupSeperator + "\n")); // add the text to the specified file
        }
    }

    // if group needs to be ended here
    public void endGroup() {
        if(isGroupEnd) {
            File.AppendAllText(Application.streamingAssetsPath + filePath, System.String.Format(groupSeperator + groupName + groupSeperator + "\n")); // add the text to the specified file
        }
    }
}
