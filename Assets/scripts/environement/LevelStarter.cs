using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelStarter : MonoBehaviour
{

    public GameObject down1;
    public GameObject down2;
    public GameObject down3;
    public GameObject go;
    public GameObject fadein;
    public AudioSource readySound;

    private void Start()
    {
        StartCoroutine(mySequence());
    }

    IEnumerator mySequence()
    {
        yield return new WaitForSeconds(1.5f);
        down3.SetActive(true);
        readySound.Play();

        yield return new WaitForSeconds(1);
        down2.SetActive(true);

        yield return new WaitForSeconds(1);
        down1.SetActive(true);

        yield return new WaitForSeconds(1);
        go.SetActive(true);
        //PlayerMove.canMove = true;

    } 
}
