using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] float spawnTime;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, spawnTime);
    }

    private void Spawn()
    {
        Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }
}
