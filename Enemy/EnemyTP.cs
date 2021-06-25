using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTP : EnemyBase
{
    public Transform BoomEffect;

    private bool isTp;
    public float TPDis=5;

    public bool IsTp { get => isTp; set
        {
            isTp = value;
            if (IsTp==true)
            {
                transform.position = PlayerMgr.Ins.transform.position;
                IsGodTimer = 1;
                StartCoroutine(OnBoom());
            }
        } }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    IEnumerator OnBoom()
    {
        yield return new WaitForSeconds(1);
     
        Destroy(Instantiate(BoomEffect, transform.position, BoomEffect.transform.rotation),1);
        PlayerHealth.currentHealth--;
        ItemMgr.Ins.OnRestShowItem(this.gameObject);
        this.gameObject.SetActive(false);
    }
    public override void Init()
    {
        base.Init();
        IsTp = false;
    }
    // Update is called once per frame
  public override void Update()
    {
        base.Update();
        if (Vector3.Distance(transform.position, PlayerMgr.Ins.transform.position) < TPDis && IsTp ==false)
        {
            IsTp = true;
        }
    }
}
