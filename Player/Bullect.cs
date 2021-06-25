using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullect : MonoBehaviour
{
    public GameObject BoomEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward,Space.Self);
    }




    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.tag=="enemy")
        {
         
            if (other.GetComponent<EnemyBase>())
            {
                other.GetComponent<EnemyBase>().MHP -= 5;
                Destroy(Instantiate(BoomEffect, transform.position, BoomEffect.transform.rotation), 1);
                Destroy(this.gameObject);
            }

           
    
        }
    }
}
