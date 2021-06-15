using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float bulet_speed = 2f;
    public float damage = 1;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 99), Time.deltaTime * bulet_speed);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Asteroid asteroid = hitInfo.GetComponent<Asteroid>();
        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
