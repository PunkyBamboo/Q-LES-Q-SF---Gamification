using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ContinueToNextScene : MonoBehaviour
{
    public string nextSceneName;
    // public Button button;
    // Start is called before the first frame update
    void Start()
    {
        // check if scene name has been set
        if(string.IsNullOrWhiteSpace(nextSceneName)) {
            Debug.Log("Scene Name is empty!");
        }
        // attach the listener to the button
        gameObject.GetComponent<Button>().onClick.AddListener(loadNextScene); // on press load the next scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // load the next scene specified
    public void loadNextScene() {
        SceneManager.LoadScene(nextSceneName);
    }


}
