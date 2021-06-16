using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float health = 1;
    public float xp = 100;
    public float scale_counter = 0.5f;

    private void Start()
    {
        transform.localScale = transform.localScale * scale_counter;


    }

    // Update is called once per frame
    private void Update()
    {
        CheckPosition();
    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    private void MoveAsteroid(Vector2 move_position, float move_speed){
        transform.position = Vector2.MoveTowards(transform.position, move_position, Time.deltaTime * move_speed);
    }

    private void CheckPosition(){
        if (transform.position.x >= 10 | 
            transform.position.x <= -10 | 
            transform.position.y >= 10 | 
            transform.position.y <= -10){
                Destroy(gameObject);
            }
    }
}
