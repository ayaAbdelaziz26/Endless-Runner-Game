using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCount : MonoBehaviour
{
    public static int coinCount=0;
    public Text myText;
    public Text myText_2;

    void Update()
    {
        myText.text = ""+coinCount.ToString();
        myText_2.text = "" + coinCount.ToString();
    }
}
