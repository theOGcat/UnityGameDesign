using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLv3 : MonoBehaviour
{
    public static Vector3 CamPosition;
    private Vector3 LastPlayerPosition;
    private Vector3 LastPlayerPosition_Temp;
    public GameObject myPrefab21;
    public GameObject myPrefab22;
    public GameObject myPrefab23;
    public GameObject myPrefab24;
    public GameObject myPrefab25;
    public GameObject myPrefab26;
    public GameObject myPrefab27;
    public GameObject myPrefab28;
    public GameObject myPrefab29;
    public GameObject myPrefab30;
    public GameObject myPrefab31;
   
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
   
   // private GameObject my13;
    public bool onetime21;
    public bool onetime22;
    public bool onetime23;
    public bool onetime24;
    public bool onetime25;
    public bool onetime26;
    public bool onetime27;
    public bool onetime28;
    public bool onetime29;
    public bool onetime30;
    public bool onetime31;
    

    void Awake()
    {
        CamPosition = new Vector3(0f, 0f, 0f);
        my1 = Instantiate(myPrefab21, new Vector3(10, 2, 0), Quaternion.identity);

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
        onetime21 = false;

    }
    void FixedUpdate()
    {
        /*
        if (onetime11)
        {
            my1 = Instantiate(myPrefab11, new Vector3(10, 2.2f, 0), Quaternion.identity);
            //my2 = Instantiate(myPrefab2, new Vector3(0, 0, 0), Quaternion.identity);
            //my3 = Instantiate(myPrefab3, new Vector3(0, 0, 0), Quaternion.identity);
        }
        */

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

        if (transform.position.x > 20 && onetime22)
        {
            my2 = Instantiate(myPrefab22, new Vector3(32, 1, 0), Quaternion.identity);
            onetime22 = false;
        }
        if (transform.position.x > 40 && onetime23)
        {
            my3 = Instantiate(myPrefab23, new Vector3(50, 0.1f, 0), Quaternion.identity);
            onetime23 = false;
            Destroy(my1);
        }
        if (transform.position.x > 60 && onetime24)
        {
            my4 = Instantiate(myPrefab24, new Vector3(70, 3.3f, 0), Quaternion.identity);
            onetime24 = false;
            Destroy(my2);
        }
        if (transform.position.x > 85 && onetime25)
        {
            my5 = Instantiate(myPrefab25, new Vector3(73, 1.3f, 0), Quaternion.identity);
            onetime25 = false;
            Destroy(my3);
        }
        if (transform.position.x > 160 && onetime26)
        {
            my6 = Instantiate(myPrefab26, new Vector3(168, 7.2f, 0), Quaternion.identity);
            onetime26 = false;
            Destroy(my4);
        }
        if (transform.position.x > 186 && onetime27)
        {
            my7 = Instantiate(myPrefab27, new Vector3(190, 3, 0), Quaternion.identity);
            onetime27 = false;
            Destroy(my5);
        }
        if (transform.position.x > 198 && onetime28)
        {
            my8 = Instantiate(myPrefab28, new Vector3(207, 3.1f, 0), Quaternion.identity);
            //my11 = Instantiate(myPrefab11, new Vector3(158, 0, 0), Quaternion.identity);
            onetime28 = false;
            Destroy(my6);
        }
        if (transform.position.x > 212 && onetime29)
        {
            my9 = Instantiate(myPrefab29, new Vector3(220, 0, 0), Quaternion.identity);
            onetime29 = false;
            Destroy(my7);
        }

        if (transform.position.x > 220 && onetime30)
        {
            my10 = Instantiate(myPrefab30, new Vector3(238, 2.5f, 0), Quaternion.identity);
            onetime30 = false;
            Destroy(my8);

        }

        if (transform.position.x > 250 && onetime31)
        {
            my11 = Instantiate(myPrefab31, new Vector3(270, 1, 0), Quaternion.identity);
            onetime31 = false;
            Destroy(my9);
        }

        
    }
}
