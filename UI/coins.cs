using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public static int counter = 0;

    void Start()
    {
        counter = PlayerPrefs.GetInt("Coins");
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            counter++;
            PlayerPrefs.SetInt("Coins", counter);
            Destroy(gameObject);
        }
    }
}
