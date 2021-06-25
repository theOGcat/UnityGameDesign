using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(20f, -7f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.CamPosition.x - transform.position.x > 10)
        {
            transform.position += new Vector3(45f, 0f, 0f);
        }
       
    }
}
