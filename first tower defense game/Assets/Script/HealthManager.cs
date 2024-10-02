using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthBarAmount = 100f;
    private bool takenDamage;
    // Start is called before the first frame update
    void Start()
    {
        Enemy.Hit += TookTheDamage;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void TookTheDamage()
    {
        takenDamage = true;
        if (takenDamage == true)
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(float damage)
    {
        healthBarAmount -= damage;
        healthBar.fillAmount = healthBarAmount / 100f;
    }

}
