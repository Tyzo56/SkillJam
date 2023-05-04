using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private int damage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == targetTag)
        {
            collision.gameObject.GetComponent<BaseHealth>().ReccountHealth(-damage);
        }
    }
}
