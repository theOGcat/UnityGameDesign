using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Vector3 LastPlayerPosition;

    void start()
    {
        LastPlayerPosition = GameObject.Find("Player").transform.position;
    }

    void FixedUpdate()
    {
        if (GameObject.Find("Player").transform.position.x >= LastPlayerPosition.x && transform.position.x < 250)
        {
            transform.position = GameObject.Find("Player").transform.position + new Vector3(-8f, 15f, 0.0f);
            LastPlayerPosition = GameObject.Find("Player").transform.position;
        }
    }
}