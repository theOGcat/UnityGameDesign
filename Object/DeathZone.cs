using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //public GameObject BackToMenuButton;
    void start()
    {

        //BackToMenuButton.SetActive(false);

    }
    void Update()
    {
        if (Camera.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(30f, 0f, 0f);
        }
        if (CameraLv2.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(30f, 0f, 0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Time.timeScale = 0;
            PlayerHealth.currentHealth = 0;
            //BackToMenuButton.SetActive(true);
            // other.gameObject.transform.position += new Vector3(0f, 22f, 0f);
        }
    }
}
