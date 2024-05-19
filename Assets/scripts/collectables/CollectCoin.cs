using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinSound;

    private void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        CoinCount.coinCount++;
        this.gameObject.SetActive(false);

    }
}
