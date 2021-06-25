using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBoss : MonoBehaviour
{
   
    // Start is called before the first frame update
    public int count;
    public GameObject Player;
    public Rigidbody rb;
    void Start()
    {
        count = 0;
        Player = GameObject.Find("Player");
        rb = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (count < 3)
        {
            count++;
            rb.AddForce(0, 800, 0);
            Debug.Log("count = " + count);

        }
        else
        {

            if (other.name == "Player")
            {

                foreach (Transform child in transform)
                    child.gameObject.SetActive(false);
                Destroy(transform.parent.gameObject, 0.01f);
                CountKilled.killedAmount += 1;
            }
        }




    }
}
