using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    [SerializeField] private Text TimeText;
    float time;

    void Update()
    {
        time += 1 * Time.deltaTime;
        TimeText.text = $"счёт: {time}";
    }
}
