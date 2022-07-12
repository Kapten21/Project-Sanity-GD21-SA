using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100;
    
    
    private void Update()
    {
       if (healthAmount < 0)
       {
         Application.LoadLevel(Application.loadedLevel);
       }

       
       
    }
    
   
        
    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
        
    }

    public void Healing(float healPoints)
    {
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount,0,100);
        healthBar.fillAmount = healthAmount / 100;
    }
 
}
