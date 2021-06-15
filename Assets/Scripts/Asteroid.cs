using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float health = 1;
    public float xp = 100;
    public float scale_counter = 1;
    private void Start()
    {
        transform.localScale = transform.localScale * scale_counter;
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            Destroy(gameObject);
        }
    }
}
