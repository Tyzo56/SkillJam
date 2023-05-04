using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody rg;


    [SerializeField] private float movementSpeed;

    private void Start()
    {
        rg = transform.GetComponent<Rigidbody>();
        rg.velocity = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
    private void OnCollisionEnter(Collision collision)
    {
        rg.velocity = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
    }
}
