using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCollected : MonoBehaviour
{
    public Text collected;
    

    // Start is called before the first frame update
    void Start()
    {
        collected = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        collected.text = "Collected: " + coins.counter;
    }
}
