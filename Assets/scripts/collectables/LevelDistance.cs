using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public Text myDistance;
    public Text myDistance_2;
    int disCount = 0;
    public bool addingDis = false;
    public static float disDelay = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDistance());
        }

        IEnumerator AddingDistance()
        {
            disCount++;
            myDistance.text = ""+disCount.ToString();
            myDistance_2.text = "" + disCount.ToString();
            yield return new WaitForSeconds(disDelay);
            addingDis = false;
        }
        
    }
}
