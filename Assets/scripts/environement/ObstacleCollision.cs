using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource collission;
    public GameObject levelControl;
    private void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        levelControl.GetComponent<LevelDistance>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        collission.Play();
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
