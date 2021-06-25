using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 1;
    public GameObject player;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            rb.AddForce(new Vector3(-250, 0, 0));
            Vector3 damageDirection = other.transform.position = transform.position;
            damageDirection = damageDirection.normalized;
            FindObjectOfType<PlayerHealth>().TakeDamage(damage, damageDirection);
        
        }
    }
}
