using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountKilled : MonoBehaviour
{
    public Text killed;
    public static int killedAmount;

    // Start is called before the first frame update
    void Start()
    {
        killedAmount = 0;
        killed = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        killed.text = "Killed: " + killedAmount;
    }
}
