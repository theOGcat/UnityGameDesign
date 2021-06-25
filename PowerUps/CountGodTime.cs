using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountGodTime : MonoBehaviour
{
    public Text GodTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GodTime.text = "GodTime: " + PlayerHealth.IsGodTimer;
    }
}
