using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    [SerializeField] private int currentHealth;
   
    public virtual void ReccountHealth(int value)
    {
        currentHealth += value;
        
        if(currentHealth <= 0)
        {
            transform.gameObject.SetActive(false);

        }
    }
    
    public int GetHealth()
    {
        return currentHealth;
    }

    
}
