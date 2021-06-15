using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform posOne;
    public Transform posTwo;
    public float speedX;
    public Vector2 vc;
    private void Start()
    {
        vc = new Vector2(posOne.position.x, posOne.position.y);
    }


    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, vc, Time.deltaTime * speedX);
        if (transform.position == posOne.position && vc.x != posTwo.position.x)
        {

            vc.x = posTwo.position.x;
        }
        else if (transform.position == posTwo.position && vc.x == posTwo.position.x)
        {
            vc.x = posOne.position.x;
        }

    }


}