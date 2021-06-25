using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemMgr : MonoBehaviour
{
    public static ItemMgr Ins;
    // Start is called before the first frame update
    void Start()
    {
        Ins = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestShowItem(GameObject Item)
    {
        StartCoroutine(RestTimerIE(()=> 
        {
            Item.gameObject.SetActive(true);
        }, UnityEngine. Random.Range(2,10)));
    }

    IEnumerator RestTimerIE(System.Action End, float DelayedTimer)
    {
        yield return new WaitForSeconds(DelayedTimer);
        End.Invoke();
    }
}
