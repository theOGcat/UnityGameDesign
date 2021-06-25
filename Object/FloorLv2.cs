using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLv2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(10f, -7f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CameraLv2.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(45f, 0f, 0f);
        }
    }
}
