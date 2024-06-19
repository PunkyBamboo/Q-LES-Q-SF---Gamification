using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAfterTime : MonoBehaviour
{
    public float waitHowLong = 15;
    public GameObject[] objectsToActivate;
    public GameObject[] objectsToDeactivate;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(waitHowLong);
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(true);
        }
        for (int i = 0; i < objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(false);
        }
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
