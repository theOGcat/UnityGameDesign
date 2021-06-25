using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMgr : MonoBehaviour
{
    public static PlayerMgr Ins;
    public float AtttackTimer;
    public Transform ShootPoint;


    public Bullect bullect;
    //public Text

    public float AddTimer;
    private void Awake()
    {
        Ins = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtttackTimer -= Time.deltaTime;
        AddTimer += Time.deltaTime;
        if (Input.GetMouseButton(0)&& AtttackTimer>0&& AddTimer>1)
        {
            AddTimer = 0;
           var temp= Instantiate(bullect, ShootPoint.position, bullect.transform.rotation);
            Destroy(temp,5);
            Debug.Log(temp.transform.position);
          //  temp.transform.forward = -ShootPoint.transform.right;
        }
    }
}
