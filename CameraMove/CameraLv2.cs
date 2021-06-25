using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLv2 : MonoBehaviour
{
    public static Vector3 CamPosition;
    private Vector3 LastPlayerPosition;
    private Vector3 LastPlayerPosition_Temp;
    public GameObject myPrefab11;
    public GameObject myPrefab12;
    public GameObject myPrefab13;
    public GameObject myPrefab14;
    public GameObject myPrefab15;
    public GameObject myPrefab16;
    public GameObject myPrefab17;
    public GameObject myPrefab18;
    public GameObject myPrefab19;
    public GameObject myPrefab20;
    public GameObject myPrefab21;
   // public GameObject myPrefab12;
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
    public bool onetime11;
    public bool onetime12;
    public bool onetime13;
    public bool onetime14;
    public bool onetime15;
    public bool onetime16;
    public bool onetime17;
    public bool onetime18;
    public bool onetime19;
    public bool onetime20;
    public bool onetime21;
    //public bool onetime12;

    void Awake()
    {
        CamPosition = new Vector3(0f, 0f, 0f);
        my1 = Instantiate(myPrefab11, new Vector3(10, 0, 0), Quaternion.identity);
        
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
        onetime11 = false;

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

        if (transform.position.x > 20 && onetime12)
        {
            my2 = Instantiate(myPrefab12, new Vector3(24, 1, 0), Quaternion.identity);
            onetime12 = false;
        }
        if (transform.position.x > 40 && onetime13)
        {
            my3 = Instantiate(myPrefab13, new Vector3(38, 0.1f, 0), Quaternion.identity);
            onetime13 = false;
            Destroy(my1);
        }
        if (transform.position.x > 60 && onetime14)
        {
            my4 = Instantiate(myPrefab14, new Vector3(70, 3.3f, 0), Quaternion.identity);
            onetime14 = false;
            Destroy(my2);
        }
        if (transform.position.x > 85 && onetime15)
        {
            my5 = Instantiate(myPrefab15, new Vector3(90, 3, 0), Quaternion.identity);
            onetime15 = false;
            Destroy(my3);
        }
        if (transform.position.x > 100 && onetime16)
        {
            my6 = Instantiate(myPrefab16, new Vector3(107, 0, 0), Quaternion.identity);
            onetime16 = false;
            Destroy(my4);
        }
        if (transform.position.x > 135 && onetime17)
        {
            my7 = Instantiate(myPrefab17, new Vector3(166, 8, 0), Quaternion.identity);
            onetime17 = false;
            Destroy(my5);
        }
        if (transform.position.x > 154 && onetime18)
        {
            my8 = Instantiate(myPrefab18, new Vector3(140, 2.6f, 0), Quaternion.identity);
            //my11 = Instantiate(myPrefab11, new Vector3(158, 0, 0), Quaternion.identity);
            onetime18 = false;
            Destroy(my6);
        }
        if (transform.position.x > 210 && onetime19)
        {
            my9 = Instantiate(myPrefab19, new Vector3(220, 0, 0), Quaternion.identity);
            onetime19 = false;
            Destroy(my7);
        }

        if (transform.position.x > 224 && onetime20)
        {
            my10 = Instantiate(myPrefab20, new Vector3(230, 0, 0), Quaternion.identity);
            onetime20 = false;
            Destroy(my8);

        }

        if (transform.position.x > 247 && onetime21)
        {
            my11 = Instantiate(myPrefab21, new Vector3(250, 1, 0), Quaternion.identity);
            onetime21 = false;
            Destroy(my9);
        }


    }
}
