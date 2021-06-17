using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{

    public float shoting_speed = 10;
    public GameObject bullet;
    public Transform firePoint;

    private void Start() {
        InvokeRepeating("Shoot", 2, 1/shoting_speed);
    }

    private void Update()
    {
        
    }

    private void Shoot()
    {
        // Debug.Log("Shot");
        Instantiate(bullet, new Vector2(firePoint.position.x, firePoint.position.y), Quaternion.identity);
    }
}
