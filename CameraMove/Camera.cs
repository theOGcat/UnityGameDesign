using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public static Vector3 CamPosition;
    private Vector3 LastPlayerPosition;
    private Vector3 LastPlayerPosition_Temp;
    public GameObject myPrefab1;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    public GameObject myPrefab4;
    public GameObject myPrefab5;
    public GameObject myPrefab6;
    public GameObject myPrefab7;
    public GameObject myPrefab8;
    public GameObject myPrefab9;
    public GameObject myPrefab10;
    public GameObject myPrefab11;
    public GameObject myPrefab12;
    private GameObject my1;
    private GameObject my2;
    private GameObject my3;
    private GameObject my4;
    private GameObject my5;
    private GameObject my6;
    private GameObject my7;
    private GameObject my8;
    private GameObject my9;
    private GameObject my10;
    private GameObject my11;
    private GameObject my12;
    public bool onetime1;
    public bool onetime2;
    public bool onetime3;
    public bool onetime4;
    public bool onetime5;
    public bool onetime6;
    public bool onetime7;
    public bool onetime8;
    public bool onetime9;
    public bool onetime10;
    public bool onetime11;
    public bool onetime12;

    void Awake()
    {
        CamPosition = new Vector3(0f, 0f, 0f);
        my1 = Instantiate(myPrefab1, new Vector3(10, 0, 0), Quaternion.identity);
    }



    void start()
    {

        LastPlayerPosition = GameObject.Find("Player").transform.position;
        //my1 = Instantiate(myPrefab1, new Vector3(10, 0, 0), Quaternion.identity);

    }

    void Update()
    {
        
        float temp = GameObject.Find("Player").transform.position.y - LastPlayerPosition_Temp.y;
        transform.position += new Vector3(0f, temp, 0f);
        LastPlayerPosition_Temp = GameObject.Find("Player").transform.position;
        onetime1 = false;
        
    }
    void FixedUpdate()
    {
        /*
            if (onetime1)
            {
                my1 = Instantiate(myPrefab1, new Vector3(10, 0, 0), Quaternion.identity);
                //my2 = Instantiate(myPrefab2, new Vector3(0, 0, 0), Quaternion.identity);
                //my3 = Instantiate(myPrefab3, new Vector3(0, 0, 0), Quaternion.identity);
            }
        */

            if (GameObject.Find("Player").transform.position.x >= LastPlayerPosition.x && transform.position.x < 260)
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

            if (transform.position.x > 15 && onetime4)
            {
                my4 = Instantiate(myPrefab4, new Vector3(-70, 8, 0), Quaternion.identity);
                onetime4 = false;
            }
            if (transform.position.x > 40 && onetime5)
            {
                my5 = Instantiate(myPrefab5, new Vector3(45, -1, 0), Quaternion.identity);
                onetime5 = false;
                Destroy(my1);
            }
            if (transform.position.x > 60 && onetime6)
            {
                my6 = Instantiate(myPrefab6, new Vector3(70, 10, 0), Quaternion.identity);
                onetime6 = false;
                Destroy(my4);
            }
            if (transform.position.x > 85 && onetime7)
            {
                my7 = Instantiate(myPrefab7, new Vector3(90, 0, 0), Quaternion.identity);
                onetime7 = false;
                Destroy(my5);
            }
            if (transform.position.x > 100 && onetime8)
            {
                my8 = Instantiate(myPrefab8, new Vector3(107, 0, 0), Quaternion.identity);
                onetime8 = false;
                Destroy(my6);
            }
            if (transform.position.x > 120 && onetime9)
            {
                my9 = Instantiate(myPrefab9, new Vector3(106, 6, 0), Quaternion.identity);
                onetime9 = false;
                Destroy(my7);
            }
            if (transform.position.x > 140 && onetime10)
            {
                my10 = Instantiate(myPrefab10, new Vector3(150, 0, 0), Quaternion.identity);
                //my11 = Instantiate(myPrefab11, new Vector3(158, 0, 0), Quaternion.identity);
                onetime10 = false;
                Destroy(my8);
            }
            if (transform.position.x > 160 && onetime2)
            {
                my2 = Instantiate(myPrefab2, new Vector3(165, 0, 0), Quaternion.identity);
                onetime2 = false;
                Destroy(my9);
            }

            if (transform.position.x > 175 && onetime3)
            {
                my3 = Instantiate(myPrefab3, new Vector3(180, 0, 0), Quaternion.identity);
                onetime3 = false;
                Destroy(my10);

            }

            if (transform.position.x > 200 && onetime12)
            {
                my12 = Instantiate(myPrefab12, new Vector3(210, 1, 0), Quaternion.identity);
                onetime12 = false;
                Destroy(my2);
            }

       
    }
}