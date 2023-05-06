using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDelete : MonoBehaviour
{
    float speed = 4f;
    float TimeToDisable = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(setDisable());
    }

    // Update is called once per frame
   
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
