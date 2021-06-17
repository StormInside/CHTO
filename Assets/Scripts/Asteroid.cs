using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float health = 1;
    public float xp = 100;
    public float scale_counter = 0.5f;

    public float move_speed = 5;
    public float rotation_speed = 5;

    private Vector2 move_position;
    private float rotate_direction;


    private void Start()
    {
        transform.localScale = transform.localScale * scale_counter;

        var move_x = Random.Range(-1.0f, 1.0f);
        var move_y = -10.0f;

        move_position = new Vector2(move_x, move_y);

        rotate_direction = Random.Range(-250, 250);
    }

    // Update is called once per frame
    private void Update()
    {
        CheckPosition();
        transform.position = Vector2.MoveTowards(transform.position, move_position, Time.deltaTime * move_speed);
        transform.Rotate(0,0,Time.deltaTime*rotate_direction);
    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    private void CheckPosition(){
        if (transform.position.x >= 10 | 
            transform.position.x <= -10 | 
            transform.position.y >= 10 | 
            transform.position.y <= -3){
                Destroy(gameObject);
            }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        PlayerMovement palyer = hitInfo.GetComponent<PlayerMovement>();
        if (palyer != null)
        {
            Debug.Log("GAME END");
        }
        Destroy(gameObject);
    }
}
