using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class DisplayPlayerName : MonoBehaviour
{
    public bool addBefore;
    public bool addAfter;
    public string addTextBefore = "";
    public string addTextAfter = "";

    void Start() {
        if(!addBefore && !addAfter) {
            gameObject.GetComponent<TMP_Text>().text = PlayerDataManagement.playerName;
        }
        if(addBefore) {
            gameObject.GetComponent<TMP_Text>().text = PlayerDataManagement.playerName + addTextBefore + " " + gameObject.GetComponent<TMP_Text>().text + addTextAfter;
        } else if(addAfter) {
            gameObject.GetComponent<TMP_Text>().text = addTextBefore + gameObject.GetComponent<TMP_Text>().text + " " + PlayerDataManagement.playerName + addTextAfter;
        }
    }
}
