using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour
{
    public Text Scores;
    // Start is called before the first frame update
    void Start()
    {
        Scores = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Scores.text = "Collected: " + coins.counter+ "\nEnemyDestroy:" + CountKilled.killedAmount;
    }
}
