using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public static int maxHealth = 10;
    public static int currentHealth;
    public PlayerHealthBar healthBar;
    public float force = 1;
    public GameObject BackToMenuButton;


    public static float IsGodTimer=0;


    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        BackToMenuButton.SetActive(false);
    }

    void Update() {

        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            currentHealth = 0;
            BackToMenuButton.SetActive(true);

        }
        
       //if (currentHealth > 0)
       // {

        //    Time.timeScale = 1;
      //  }


    }

    private void FixedUpdate()
    {
        
        if (IsGodTimer>0)
        {
            IsGodTimer -= Time.deltaTime;
            currentHealth = maxHealth;
        }

        if (IsGodTimer <= 0)
        {

            IsGodTimer = 0;

        }

    }


    public void HealthRegen() {


        currentHealth += 1;
        healthBar.SetHealth(currentHealth);
    }


    public void TakeDamage(int damage,Vector3 direction)
    {

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy") {

            Vector3 pushDirection = other.transform.position = transform.position;
            pushDirection =- pushDirection.normalized;
            GetComponent<Rigidbody>().AddForce(pushDirection * force * 100);
        
        }
    }


}
