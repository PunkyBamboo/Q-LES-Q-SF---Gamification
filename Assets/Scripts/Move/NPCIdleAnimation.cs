using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCIdleAnimation : MonoBehaviour
{
    //set idle animation speed
    public float idleAnimationSpeed = 1;

    //set idle animation size
    public float idleAnimationSize = 1f;

    //create a variable to hold the initial size
    private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        //get the initial scale of the game object
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 idleScale = new Vector3(
            initialScale.x + (Mathf.Sin(Time.time * idleAnimationSpeed) * idleAnimationSize),
            initialScale.y + (Mathf.Sin(Time.time * idleAnimationSpeed) * idleAnimationSize),
            initialScale.z
        );

        transform.localScale = idleScale;
    }
}
