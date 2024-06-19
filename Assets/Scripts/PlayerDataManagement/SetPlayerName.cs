using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class SetPlayerName : MonoBehaviour
{
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(setName); // on press save the user input
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setName() {
        PlayerDataManagement.playerName = inputField.text;
    }
}
