﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv3floor1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraLv3.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(45f, 0f, 0f);
        }
    }
}
