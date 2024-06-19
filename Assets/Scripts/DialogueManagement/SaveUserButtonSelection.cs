using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class SaveUserButtonSelection : MonoBehaviour
{
    // global variables
    private string input;   // for easier call of variable
    public Button[] buttons; // our toggle group object
    private string filePath = "UserData/userAnswers.txt";
    public string textBeforeAnswer = "";
    public string textAfterAnswer = "";
    private string groupSeperator = "----------------------------";
    public string groupName = "New Group";
    public bool isGroupStart;
    public bool isGroupEnd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // public string fourthLabel;
    // save the user input
    void saveUserInput(string textToSave) {
        saveToFile(textToSave);
    }

    // get the user input
    public string getUserInput() {
        return input;
    }

    public void saveToFile(string text) {
        // check if this is the start of a new group
        startNewGroup();
        // add text
        File.AppendAllText(filePath, System.String.Format(textBeforeAnswer + " " + text + textAfterAnswer + "\n")); // add the text to the specified file
        // check if this is the end of a group
        endGroup();
    }

    // if elements need to be grouped
    public void startNewGroup() {
        if(isGroupStart) {
            File.AppendAllText(filePath, System.String.Format("\n" + groupSeperator + groupName + groupSeperator + "\n")); // add the text to the specified file
        }
    }

    // if group needs to be ended here
    public void endGroup() {
        if(isGroupEnd) {
            File.AppendAllText(filePath, System.String.Format(groupSeperator + groupName + groupSeperator + "\n")); // add the text to the specified file
        }
    }
}
