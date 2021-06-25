using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float distance=5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {

            if (Move.getPowerTeleport == false)
            {

                Move.getPowerTeleport = true;
                Move.teleport = 5;

            }
            Destroy(transform.gameObject, 0.01f);

        }
    }

    


}
