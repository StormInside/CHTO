using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulet_speed = 2;
    public float damage = 1;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, -99), Time.deltaTime * bulet_speed);
        CheckPosition();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Asteroid asteroid = hitInfo.GetComponent<Asteroid>();
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
        }else if (enemy != null){
            enemy.TakeDamage(damage);
        }else if (player != null){
            // player.TakeDamage(damage);
            Debug.Log("Damage Player");
        }
        Destroy(gameObject);
    }

    private void CheckPosition(){
        if (transform.position.y <= -3){
                Destroy(gameObject);
            }
    }

}
