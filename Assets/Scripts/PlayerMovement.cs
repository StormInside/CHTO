using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float posOne = 2.3f;
    private float posTwo = -2.3f;

    private float speed;
    public float default_speed = 5f;

    private bool holding;

    private Vector2 vc;


    private void Start()
    {
        speed = default_speed;
        vc = new Vector2(posOne, 0);
    }


    private void FixedUpdate()
    {
        // Debug.Log("player speed = "+ speed);
        transform.position = Vector2.MoveTowards(transform.position, vc, Time.deltaTime * speed);

        if (transform.position.x == posOne && vc.x != posTwo)
        {

            vc.x = posTwo;
        }
        else if (transform.position.x == posTwo && vc.x != posOne)
        {
            vc.x = posOne;
        }

    }

    public void slowDownPlayer() {
        if (!holding) {
            speed = speed / 2;
            holding = true;
        }
    }
    public void speedUpPlayer()
    {
        if (!holding)
        {
            speed = speed * 2;
            holding = true;
        }
    }

    public void restorePlayerSpeed()
    {
        holding = false;
        speed = default_speed;
    }


}