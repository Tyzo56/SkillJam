using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject EndPanel;
    [SerializeField] GameObject player;

    private void Update()
    {
        GameEnd();
    }
    public void GameEnd()
    {
        int health = player.GetComponent<BaseHealth>().GetHealth();

        if (health <= 0)
        {
            EndPanel.SetActive(true);
        }
    }
}
