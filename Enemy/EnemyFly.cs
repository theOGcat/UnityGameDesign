using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : EnemyBase
{
    public float TPDis = 5;

    public float BoomDis=1;

    public Vector3 StartPos;


    public override void Init()
    {
        base.Init();transform.position = StartPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    public override void Update()
    {
        base.Update();
        if (Vector3.Distance(transform.position, PlayerMgr.Ins.transform.position) < TPDis)
        {
            transform.position += (PlayerMgr.Ins.transform.position - transform.position).normalized * Time.deltaTime * 3;
            if (Vector3.Distance(transform.position, PlayerMgr.Ins.transform.position) < BoomDis)
            {
                PlayerHealth.currentHealth--;
                ItemMgr.Ins.OnRestShowItem(this.gameObject);
                this.gameObject.SetActive(false);
            }
        }
    }
}
