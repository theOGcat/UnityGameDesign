using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGod : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth.IsGodTimer = 5;
            this.gameObject.SetActive(false);
            //ItemMgr.Ins.OnRestShowItem(this.gameObject);
            
        }
    }
}
