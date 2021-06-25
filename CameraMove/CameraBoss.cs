using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoss : MonoBehaviour
{
    public static Vector3 CamPosition;
    private Vector3 LastPlayerPosition;
    private Vector3 LastPlayerPosition_Temp;
    public GameObject myPrefab41;
    public GameObject myPrefab42;
    

    private GameObject my1;
    private GameObject my2;
    

    // private GameObject my13;
    public bool onetime41;
    public bool onetime42;
   


    void Awake()
    {
        CamPosition = new Vector3(0f, 0f, 0f);
        my1 = Instantiate(myPrefab41, new Vector3(10, 0.2f, 0), Quaternion.identity);
        
    }


    void start()
    {
        
        LastPlayerPosition = GameObject.Find("Player").transform.position;
    }

    void Update()
    {

        float temp = GameObject.Find("Player").transform.position.y - LastPlayerPosition_Temp.y;
        transform.position += new Vector3(0f, temp, 0f);
        LastPlayerPosition_Temp = GameObject.Find("Player").transform.position;
        //onetime41 = false;
        
    }
    void FixedUpdate()
    {
       

        if (GameObject.Find("Player").transform.position.x >= LastPlayerPosition.x && transform.position.x < 350)
        {
            Vector3 newPos = GameObject.Find("Player").transform.position + new Vector3(0, 0, -11);
            Vector3 pos = Vector3.Slerp(transform.position, newPos, 1f);
            transform.position = pos; ;
            transform.LookAt(GameObject.Find("Player").transform.position);
            transform.position += new Vector3(150, 100, 0) * Time.deltaTime;
            CamPosition = transform.position;
            LastPlayerPosition = GameObject.Find("Player").transform.position;
            LastPlayerPosition_Temp = LastPlayerPosition;
        }


        if (GameObject.Find("EnemyBoss(Clone)") == null&&onetime42==true)
        {

            
            my2 = Instantiate(myPrefab42, new Vector3(24, 1, 0), Quaternion.identity);
            onetime42 = false;
            //Debug.Log("sb");
        }


    }
}
