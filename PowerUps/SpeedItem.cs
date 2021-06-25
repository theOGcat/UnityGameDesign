using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Move.MoveSpeedTimer = 30;
            this.gameObject.SetActive(false);
            ItemMgr.Ins.OnRestShowItem(this.gameObject);
        }
    }
}
