using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float bulet_speed = 2;
    public float damage = 1;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 99), Time.deltaTime * bulet_speed);
        CheckPosition();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Asteroid asteroid = hitInfo.GetComponent<Asteroid>();
        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
        }
        Destroy(gameObject);
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
