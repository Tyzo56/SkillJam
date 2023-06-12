using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDelete : MonoBehaviour
{
   
    float TimeToDisable = 2f;
    
    void Start()
    {
        StartCoroutine(setDisable());
    }

   
   
    IEnumerator setDisable()
    {
        yield return new WaitForSeconds(TimeToDisable);
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopCoroutine(setDisable());
        gameObject.SetActive(false);
    }
}
