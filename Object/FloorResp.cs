using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorResp: MonoBehaviour
{
    //public GameObject obj;
    void Start() {
        //transform.position = new Vector3(0, -5, 0);
        //Time.timeScale = 1;

    }

    void Update()
    {
        if (Camera.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(45f, 0f, 0f);
        }
        

    }
}
