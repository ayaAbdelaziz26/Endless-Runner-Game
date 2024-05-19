using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDistance;
    public GameObject endScreen;
    public GameObject powerup;
    //public GameObject fadeOut;
    void Start()
    {
        StartCoroutine(endSequence());
        
    }

    IEnumerator endSequence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDistance.SetActive(false);
        powerup.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
}
