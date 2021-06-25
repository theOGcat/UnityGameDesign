using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;

    // Update is called once per frame
    public void SetMaxHealth(int health)
    {
        
        slider.maxValue = health;
        slider.value = health;
        health = PlayerHealth.currentHealth;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
