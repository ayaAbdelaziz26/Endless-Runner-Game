using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandPowerups : MonoBehaviour
{
    public GameObject[] powerups;
    public GameObject player;
    public Transform myParent;
    public float range = 3.5f;
    void Start()
    {
        StartCoroutine(create());
        
    }

    IEnumerator create()
    {
        yield return new WaitForSeconds(10);
        while (true)
        {
            GameObject mypowerup = Instantiate(powerups[0],
                new Vector3(Random.Range(-range, range), transform.position.y, player.transform.position.z+50.0f),
                powerups[0].transform.rotation,myParent);
            yield return new WaitForSeconds(40);
        }
    }
}
