using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject EndPanel;
    [SerializeField] GameObject player;
    [SerializeField] Text healthText;

    private void Update()
    {
        GameEnd();
    }
    public void GameEnd()
    {
        int health = player.GetComponent<BaseHealth>().GetHealth();
        healthText.text = $"здоровье: {health}";
        if (health <= 0)
        {
            EndPanel.SetActive(true);
        }
    }
}
