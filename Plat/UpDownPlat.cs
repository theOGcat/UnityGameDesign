using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlat : MonoBehaviour
{
    public Transform PlatformLiuda;
    public bool moveDown = false;
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
        if (PlatformLiuda.position.y <= (startingPosition.y + 11.0f) && moveDown == false)
        {
            moveUp();
        }
        else
        {
            moveDown = true;
            moveDownward();
        }

    }

    void moveUp()
    {
        PlatformLiuda.position += Vector3.up * Time.deltaTime * speed;
    }

    void moveDownward()
    {
        PlatformLiuda.position += Vector3.down * Time.deltaTime * speed;
        if (PlatformLiuda.position.y <= startingPosition.y)
        {
            moveDown = false;
        }
    }

}
