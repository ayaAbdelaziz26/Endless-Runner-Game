using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedPowerup : MonoBehaviour
{
    public GameObject mybox;
    public Text mytext;
    GameObject mycontrol;
    GameObject myplayer;
    public int Time = 20;

    void Start()
    {
        mycontrol = GameObject.Find("LevelControl");
        myplayer = GameObject.Find("player");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            Time = 20;
            mybox.SetActive(true);
            StartCoroutine(mydoublespeed());
        }
    }

    IEnumerator mydoublespeed()
    {
        while (Time > 0)
        {
            LevelDistance.disDelay = 0.05f;
            PlayerMove.RunSpeed = 16.0f;
            mytext.text = Time.ToString();
            Time -= 1;
            yield return new WaitForSeconds(1);
        }
        mybox.SetActive(false);
        PlayerMove.RunSpeed = 12.0f;
        LevelDistance.disDelay = 0.1f;
    }
}
