using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegen : MonoBehaviour
{
    public GameObject Player;
    public static bool getPowerHealth = false;
    public int heal = 1;

    public PlayerHealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
       // Player = GameObject.Find("Player");
       // healthBar = Player.GetComponent<PlayerHealthBar>();
    }

    // Update is called once per frame
    void Update()
    {

        if (getPowerHealth == true)
        {
            
            GetHealthRegen();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            
            if (getPowerHealth == false)
            {
                getPowerHealth = true;


            }
            Destroy(transform.gameObject, 0.01f);

        }
    }


    void GetHealthRegen()
    {

        getPowerHealth = false;
        FindObjectOfType<PlayerHealth>().HealthRegen();
        



    }


}
