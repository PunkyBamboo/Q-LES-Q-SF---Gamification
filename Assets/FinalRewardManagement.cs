using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEditor;
using System.Text;

public class FinalRewardManagement : MonoBehaviour
{
    public GameObject[] allPotions;
    public TMP_Text collectedFinalReward;
    // Start is called before the first frame update
    void Start()
    {
        // gameObject.GetComponent<Button>().onClick.AddListener(addFinalRewardPart); // on press increase the xp
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addFinalRewardPart() {
        PlayerDataManagement.collectedFinalRewardParts++;
        for(int i = 0; i < PlayerDataManagement.collectedFinalRewardParts; i++) {   // traverse the array as long as i is smaller than the final reward part variable
            allPotions[i].GetComponent<Image>().color = new Color32(255,255,255,255);
        }
        collectedFinalReward.SetText(PlayerDataManagement.collectedFinalRewardParts.ToString() + " / 16");
    }
}
