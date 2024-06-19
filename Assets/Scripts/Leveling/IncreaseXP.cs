using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreaseXP : MonoBehaviour
{
    public LevelSystem LevelSystem; // call to the lvl system script to be able to use its methods
    public int amountToIncrease = 25;   // amount to increase xp by; change this in the unity ui!!

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(addExperience); // on press increase the xp
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addExperience() {
        LevelSystem.addExperience(amountToIncrease);    // increase the xp
        LevelSystem.updateLevelandXP(); // update the visuals
    }
}
