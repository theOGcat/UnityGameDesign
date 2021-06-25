using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    private int mHP = 5;

    public float IsGodTimer;

    public int MHP { get => mHP; set
        {
            if(IsGodTimer<=0)
            mHP = value;

            if (mHP<=0)
            {
                ItemMgr.Ins.OnRestShowItem(this.gameObject);
                mHP = 5; Init();
                CountKilled.killedAmount++;
                this.gameObject.SetActive(false);



            }
        } }

    public virtual void Init()
    {

    }
    // Update is called once per frame
   public virtual void Update()
    {
        IsGodTimer -= Time.deltaTime;
    }

   
}
