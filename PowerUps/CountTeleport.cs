using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountTeleport : MonoBehaviour
{
    public Text Teleported;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Teleported.text = "TeleportRemain: " + Move.teleport;
    }
}
