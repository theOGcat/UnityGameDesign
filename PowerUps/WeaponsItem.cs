using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsItem : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            PlayerMgr.Ins.AtttackTimer = 30;
            this.gameObject.SetActive(false);
            ItemMgr.Ins.OnRestShowItem(this.gameObject);
        }
    }
}
