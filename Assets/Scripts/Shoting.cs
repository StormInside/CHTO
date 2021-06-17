using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{

    public float shoting_speed = 10;
    public GameObject bullet;
    public Transform firePoint;

    private bool is_shoting = false;

    private void Start() {
        InvokeRepeating("Shoot", 2, 1/shoting_speed);
        
    }

    private void Update()
    {
        
    }

    private void Shoot()
    {
        // Debug.Log("Shot");
        if (is_shoting){
            Instantiate(bullet, new Vector2(firePoint.position.x, firePoint.position.y), Quaternion.identity);
        }
    }

    public void StartShoting(){
        is_shoting = true;
    }

    public void StopShoting(){
        is_shoting = false;
    }
}
