using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string parentName;
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(destroyClone());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroyClone()
    {
        yield return new WaitForSeconds(180);
        if(parentName=="Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
