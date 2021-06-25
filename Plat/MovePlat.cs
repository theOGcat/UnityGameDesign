using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour
{
    public Transform PlatformLiuda;
    public bool moveLeft = false;
    private float speed = 3;
    public Vector3 startingPosition;
    public Vector3 endPosition;

    void Start()
    {
        PlatformLiuda = this.transform;
        startingPosition = PlatformLiuda.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlatformLiuda.position.x <= (startingPosition.x + 5.0f) && moveLeft == false)
        {
            moveRight();
        }
        else
        {
            moveLeft = true;
            movetoLeft();
        }

    }

    void moveRight()
    {
        PlatformLiuda.position += Vector3.right * Time.deltaTime * speed;
    }

    void movetoLeft()
    {
        PlatformLiuda.position += Vector3.left * Time.deltaTime * speed;
        if (PlatformLiuda.position.x <= startingPosition.x)
        {
            moveLeft = false;
        }
    }



}
